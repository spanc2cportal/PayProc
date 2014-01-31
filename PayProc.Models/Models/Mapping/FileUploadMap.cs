using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PayProc.Models.Mapping
{
    public class FileUploadMap : EntityTypeConfiguration<FileUpload>
    {
        public FileUploadMap()
        {
            // Primary Key
            this.HasKey(t => t.FileId);

            // Properties
            this.Property(t => t.FileName)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("FileUpload");
            this.Property(t => t.FileId).HasColumnName("FileId");
            this.Property(t => t.FileName).HasColumnName("FileName");
            this.Property(t => t.UploadTime).HasColumnName("UploadTime");
            this.Property(t => t.BillCount).HasColumnName("BillCount");
            this.Property(t => t.SuccessCount).HasColumnName("SuccessCount");
        }
    }
}
