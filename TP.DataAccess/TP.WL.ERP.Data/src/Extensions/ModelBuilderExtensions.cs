using System;
using System.Data.Entity.ModelConfiguration;
using TP.Data.EntityFramework.Entities;
using TP.Data.EntityFramework.Entities.Workflow;
using TP.Infrastructure.Common.Enums;

namespace TP.WL.ERP.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void WithTraceable<TEntity>(this EntityTypeConfiguration<TEntity> entity) where TEntity : class, ITraceable
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            
            entity.Property(x => x.CreateDate).IsRequired();
            entity.Property(x => x.ModifyDate).IsRequired();
            
            entity.HasRequired(x => x.Creator).WithMany().HasForeignKey(k => k.CreatorId).WillCascadeOnDelete(false);
            entity.HasRequired(x => x.Modificator).WithMany().HasForeignKey(k => k.ModificatorId).WillCascadeOnDelete(false);
        }

        public static void WithApplication<TEntity>(this EntityTypeConfiguration<TEntity> entity) where TEntity : ApplicationBase
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            entity.Property(x => x.Number).HasMaxLength(32).IsRequired();
            entity.Property<ApplicationStatus>(x => x.Status).IsRequired();
            entity.Property(x => x.CreateDate).IsRequired();
            entity.Property(x => x.ModifyDate).IsRequired();
            
            entity.HasRequired(x => x.Applicant).WithMany().HasForeignKey(k => k.ApplicantId).WillCascadeOnDelete(false);
            entity.HasOptional(x => x.WorkflowInstance).WithMany().HasForeignKey(k => k.InstanceId).WillCascadeOnDelete(false);
            entity.HasRequired(x => x.Creator).WithMany().HasForeignKey(k => k.CreatorId).WillCascadeOnDelete(false);
            entity.HasRequired(x => x.Modificator).WithMany().HasForeignKey(k => k.ModificatorId).WillCascadeOnDelete(false);
        }

        public static void WithWorkflowLog<TEntity>(this EntityTypeConfiguration<TEntity> entity) where TEntity : class, IWorkflowLog
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            entity.Property(x => x.Comment).HasMaxLength(1024);
            entity.Property<ActionStatus>(x => x.Status).IsRequired();
            entity.Property(x => x.IpAddress).HasMaxLength(20);
            
            entity.HasRequired(x => x.Instance).WithMany().HasForeignKey(k => k.InstanceId).WillCascadeOnDelete(false);
            entity.HasRequired(x => x.Origin).WithMany().HasForeignKey(k => k.OriginId).WillCascadeOnDelete(false);
            entity.HasOptional(x => x.Destinagion).WithMany().HasForeignKey(k => k.DestinagionId).WillCascadeOnDelete(false);
            entity.HasRequired(x => x.Checker).WithMany().HasForeignKey(k => k.CheckerId).WillCascadeOnDelete(false);
            entity.HasOptional(x => x.Agent).WithMany().HasForeignKey(k => k.AgentId).WillCascadeOnDelete(false);
        }
    }
}
