using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PayProc.Models.Mapping
{
    public class TemplateTypeMap : EntityTypeConfiguration<TemplateType>
    {
        public TemplateTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.TemplateTypeId);

            // Properties
            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TemplateType");
            this.Property(t => t.TemplateTypeId).HasColumnName("TemplateTypeId");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
