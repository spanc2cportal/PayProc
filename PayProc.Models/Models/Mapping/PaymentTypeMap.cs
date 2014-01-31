using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PayProc.Models.Mapping
{
    public class PaymentTypeMap : EntityTypeConfiguration<PaymentType>
    {
        public PaymentTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.PaymentTypeId);

            // Properties
            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PaymentType");
            this.Property(t => t.PaymentTypeId).HasColumnName("PaymentTypeId");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
