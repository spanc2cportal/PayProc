using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PayProc.Models.Mapping
{
    public class CutoffTypeMap : EntityTypeConfiguration<CutoffType>
    {
        public CutoffTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.CutoffId);

            // Properties
            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CutoffType");
            this.Property(t => t.CutoffId).HasColumnName("CutoffId");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
