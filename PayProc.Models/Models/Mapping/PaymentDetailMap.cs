using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PayProc.Models.Mapping
{
    public class PaymentDetailMap : EntityTypeConfiguration<PaymentDetail>
    {
        public PaymentDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.PaymentId);

            // Properties
            this.Property(t => t.PaymentId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.StringValue1)
                .HasMaxLength(50);

            this.Property(t => t.StringValue2)
                .HasMaxLength(50);

            this.Property(t => t.StringValue3)
                .HasMaxLength(50);

            this.Property(t => t.StringValue4)
                .HasMaxLength(50);

            this.Property(t => t.StringValue5)
                .HasMaxLength(50);

            this.Property(t => t.StringValue6)
                .HasMaxLength(50);

            this.Property(t => t.StringValue7)
                .HasMaxLength(50);

            this.Property(t => t.Encrypted1)
                .HasMaxLength(500);

            this.Property(t => t.Encrypted2)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("PaymentDetail");
            this.Property(t => t.PaymentId).HasColumnName("PaymentId");
            this.Property(t => t.StringValue1).HasColumnName("StringValue1");
            this.Property(t => t.StringValue2).HasColumnName("StringValue2");
            this.Property(t => t.StringValue3).HasColumnName("StringValue3");
            this.Property(t => t.StringValue4).HasColumnName("StringValue4");
            this.Property(t => t.StringValue5).HasColumnName("StringValue5");
            this.Property(t => t.StringValue6).HasColumnName("StringValue6");
            this.Property(t => t.StringValue7).HasColumnName("StringValue7");
            this.Property(t => t.Integer1).HasColumnName("Integer1");
            this.Property(t => t.Integer2).HasColumnName("Integer2");
            this.Property(t => t.Integer3).HasColumnName("Integer3");
            this.Property(t => t.Decimal1).HasColumnName("Decimal1");
            this.Property(t => t.Decimal2).HasColumnName("Decimal2");
            this.Property(t => t.Decimal3).HasColumnName("Decimal3");
            this.Property(t => t.Date1).HasColumnName("Date1");
            this.Property(t => t.Date2).HasColumnName("Date2");
            this.Property(t => t.Date3).HasColumnName("Date3");
            this.Property(t => t.Encrypted1).HasColumnName("Encrypted1");
            this.Property(t => t.Encrypted2).HasColumnName("Encrypted2");

            // Relationships
            this.HasRequired(t => t.Payment)
                .WithOptional(t => t.PaymentDetail);

        }
    }
}
