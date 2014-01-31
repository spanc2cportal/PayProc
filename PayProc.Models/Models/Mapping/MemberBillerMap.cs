using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PayProc.Models.Mapping
{
    public class MemberBillerMap : EntityTypeConfiguration<MemberBiller>
    {
        public MemberBillerMap()
        {
            // Primary Key
            this.HasKey(t => t.MemberBillerId);

            // Properties
            this.Property(t => t.MemberBillerId)
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
            this.ToTable("MemberBiller");
            this.Property(t => t.MemberBillerId).HasColumnName("MemberBillerId");
            this.Property(t => t.AccountId).HasColumnName("AccountId");
            this.Property(t => t.BillerId).HasColumnName("BillerId");
            this.Property(t => t.StateId).HasColumnName("StateId");
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
            this.Property(t => t.LastPaymentId).HasColumnName("LastPaymentId");

            // Relationships
            this.HasRequired(t => t.Biller)
                .WithMany(t => t.MemberBillers)
                .HasForeignKey(d => d.BillerId);
            this.HasRequired(t => t.MemberAccount)
                .WithMany(t => t.MemberBillers)
                .HasForeignKey(d => d.AccountId);
            this.HasRequired(t => t.State)
                .WithMany(t => t.MemberBillers)
                .HasForeignKey(d => d.StateId);
            this.HasOptional(t => t.Payment)
                .WithMany(t => t.MemberBillers)
                .HasForeignKey(d => d.LastPaymentId);

        }
    }
}
