using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PayProc.Models.Mapping
{
    public class PaymentFlowMap : EntityTypeConfiguration<PaymentFlow>
    {
        public PaymentFlowMap()
        {
            // Primary Key
            this.HasKey(t => t.PaymentFlowId);

            // Properties
            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PaymentFlow");
            this.Property(t => t.PaymentFlowId).HasColumnName("PaymentFlowId");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
