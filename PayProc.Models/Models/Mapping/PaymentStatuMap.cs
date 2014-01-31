using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PayProc.Models.Mapping
{
    public class PaymentStatuMap : EntityTypeConfiguration<PaymentStatu>
    {
        public PaymentStatuMap()
        {
            // Primary Key
            this.HasKey(t => t.PaymentStatusId);

            // Properties
            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PaymentStatus");
            this.Property(t => t.PaymentStatusId).HasColumnName("PaymentStatusId");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
