using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PayProc.Models.Mapping
{
    public class BillerMap : EntityTypeConfiguration<Biller>
    {
        public BillerMap()
        {
            // Primary Key
            this.HasKey(t => t.BillerId);

            // Properties
            this.Property(t => t.BillerName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.BillerDescription)
                .HasMaxLength(100);

            this.Property(t => t.IsActive)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.AddressLine1)
                .HasMaxLength(100);

            this.Property(t => t.AddressLine2)
                .HasMaxLength(100);

            this.Property(t => t.City)
                .HasMaxLength(100);

            this.Property(t => t.ZipCode)
                .HasMaxLength(100);

            this.Property(t => t.Phone)
                .HasMaxLength(15);

            this.Property(t => t.IsClient)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.CutOffValue)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Biller");
            this.Property(t => t.BillerId).HasColumnName("BillerId");
            this.Property(t => t.BillerName).HasColumnName("BillerName");
            this.Property(t => t.BillerDescription).HasColumnName("BillerDescription");
            this.Property(t => t.UtilityId).HasColumnName("UtilityId");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.AddressLine1).HasColumnName("AddressLine1");
            this.Property(t => t.AddressLine2).HasColumnName("AddressLine2");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.ZipCode).HasColumnName("ZipCode");
            this.Property(t => t.StateId).HasColumnName("StateId");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.IsClient).HasColumnName("IsClient");
            this.Property(t => t.CutoffId).HasColumnName("CutoffId");
            this.Property(t => t.CutOffValue).HasColumnName("CutOffValue");
            this.Property(t => t.PayTypeId).HasColumnName("PayTypeId");

            // Relationships
            this.HasRequired(t => t.AmountPayType)
                .WithMany(t => t.Billers)
                .HasForeignKey(d => d.PayTypeId);
            this.HasRequired(t => t.Utility)
                .WithMany(t => t.Billers)
                .HasForeignKey(d => d.UtilityId);
            this.HasRequired(t => t.CutoffType)
                .WithMany(t => t.Billers)
                .HasForeignKey(d => d.CutoffId);

        }
    }
}
