﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TP.WL.ERP.Data.Entities.Crm;
using TP.WL.ERP.Data.Extensions;

namespace TP.WL.ERP.Data.Mappings.Crm
{
    public class ClientContactMap : EntityTypeConfiguration<ClientContact>
    {
        public ClientContactMap()
        {
            this.ToTable("tpwl_crm_ClientContacts");

            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            
            this.Property(x => x.DisplayName).HasMaxLength(256).IsRequired();
            this.Property(x => x.Designation).HasMaxLength(256);
            this.Property(x => x.Phone).HasMaxLength(20);
            this.Property(x => x.Mobile).HasMaxLength(20);
            this.Property(x => x.Email).HasMaxLength(256);
            this.Property(x => x.Remark).HasMaxLength(1024);

            this.HasRequired(x => x.Client).WithMany(y => y.Contacts).HasForeignKey(k => k.ClientId).WillCascadeOnDelete(false);

            this.WithTraceable();
        }
    }
}
