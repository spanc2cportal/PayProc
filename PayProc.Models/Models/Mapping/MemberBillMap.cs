using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PayProc.Models.Mapping
{
    public class MemberBillMap : EntityTypeConfiguration<MemberBill>
    {
        public MemberBillMap()
        {
            // Primary Key
            this.HasKey(t => t.MemberBillId);

            // Properties
            this.Property(t => t.BillNumber)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.FileLocationPath)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("MemberBill");
            this.Property(t => t.MemberBillId).HasColumnName("MemberBillId");
            this.Property(t => t.BillNumber).HasColumnName("BillNumber");
            this.Property(t => t.RecievedTime).HasColumnName("RecievedTime");
            this.Property(t => t.FileLocationPath).HasColumnName("FileLocationPath");
            this.Property(t => t.BillerId).HasColumnName("BillerId");
            this.Property(t => t.BillAmount).HasColumnName("BillAmount");
            this.Property(t => t.BillDate).HasColumnName("BillDate");
            this.Property(t => t.DueDate).HasColumnName("DueDate");
            this.Property(t => t.FileId).HasColumnName("FileId");

            // Relationships
            this.HasRequired(t => t.FileUpload)
                .WithMany(t => t.MemberBills)
                .HasForeignKey(d => d.FileId);
            this.HasRequired(t => t.MemberBiller)
                .WithMany(t => t.MemberBills)
                .HasForeignKey(d => d.BillerId);

        }
    }
}
