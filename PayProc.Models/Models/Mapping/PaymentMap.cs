using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PayProc.Models.Mapping
{
    public class PaymentMap : EntityTypeConfiguration<Payment>
    {
        public PaymentMap()
        {
            // Primary Key
            this.HasKey(t => t.PaymentId);

            // Properties
            this.Property(t => t.ReferenceNumber)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PaymentNumber)
                .HasMaxLength(50);

            this.Property(t => t.ClientIp)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Payment");
            this.Property(t => t.PaymentId).HasColumnName("PaymentId");
            this.Property(t => t.BillerId).HasColumnName("BillerId");
            this.Property(t => t.AccountId).HasColumnName("AccountId");
            this.Property(t => t.MemberBillId).HasColumnName("MemberBillId");
            this.Property(t => t.ReferenceNumber).HasColumnName("ReferenceNumber");
            this.Property(t => t.PaymentNumber).HasColumnName("PaymentNumber");
            this.Property(t => t.PaymentTime).HasColumnName("PaymentTime");
            this.Property(t => t.PaymentStatusId).HasColumnName("PaymentStatusId");
            this.Property(t => t.PaymentTypeId).HasColumnName("PaymentTypeId");
            this.Property(t => t.ClientIp).HasColumnName("ClientIp");
            this.Property(t => t.PaymentFlowId).HasColumnName("PaymentFlowId");

            // Relationships
            this.HasRequired(t => t.Biller)
                .WithMany(t => t.Payments)
                .HasForeignKey(d => d.BillerId);
            this.HasOptional(t => t.MemberAccount)
                .WithMany(t => t.Payments)
                .HasForeignKey(d => d.AccountId);
            this.HasOptional(t => t.MemberBill)
                .WithMany(t => t.Payments)
                .HasForeignKey(d => d.MemberBillId);
            this.HasRequired(t => t.PaymentFlow)
                .WithMany(t => t.Payments)
                .HasForeignKey(d => d.PaymentFlowId);
            this.HasRequired(t => t.PaymentStatu)
                .WithMany(t => t.Payments)
                .HasForeignKey(d => d.PaymentStatusId);
            this.HasRequired(t => t.PaymentType)
                .WithMany(t => t.Payments)
                .HasForeignKey(d => d.PaymentTypeId);

        }
    }
}
