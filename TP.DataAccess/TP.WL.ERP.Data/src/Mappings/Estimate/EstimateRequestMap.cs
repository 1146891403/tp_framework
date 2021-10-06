using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TP.Infrastructure.Common.Enums;
using TP.WL.ERP.Data.Entities.Estimate;
using TP.WL.ERP.Data.Extensions;

namespace TP.WL.ERP.Data.Mappings.Estimate
{
    public class EstimateRequestMap : EntityTypeConfiguration<EstimateRequest>
    {
        public EstimateRequestMap()
        {
            this.ToTable("tpwl_est_EstimateRequests");
            
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(x => x.ClientName).HasMaxLength(256).IsRequired();
            this.Property(x => x.ClientLevel).HasMaxLength(10).IsRequired();
            this.Property(x => x.Salesman).HasMaxLength(256).IsRequired();
            this.Property<Currency>(x => x.Currency).IsRequired();

            this.HasRequired(x => x.Client).WithMany().HasForeignKey(k => k.ClientId).WillCascadeOnDelete(false);
            this.HasRequired(x => x.Sales).WithMany().HasForeignKey(k => k.SalesmanId).WillCascadeOnDelete(false);

            this.WithApplication();
        }
    }
}
