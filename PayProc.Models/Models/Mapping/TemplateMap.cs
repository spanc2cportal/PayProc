using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PayProc.Models.Mapping
{
    public class TemplateMap : EntityTypeConfiguration<Template>
    {
        public TemplateMap()
        {
            // Primary Key
            this.HasKey(t => t.TemplateId);

            // Properties
            this.Property(t => t.TemplatePath)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("Template");
            this.Property(t => t.TemplateId).HasColumnName("TemplateId");
            this.Property(t => t.TemplateTypeId).HasColumnName("TemplateTypeId");
            this.Property(t => t.TemplatePath).HasColumnName("TemplatePath");
            this.Property(t => t.AttributeCount).HasColumnName("AttributeCount");

            // Relationships
            this.HasRequired(t => t.TemplateType)
                .WithMany(t => t.Templates)
                .HasForeignKey(d => d.TemplateTypeId);

        }
    }
}
