using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PayProc.Models.Mapping
{
    public class TemplateAttributeMap : EntityTypeConfiguration<TemplateAttribute>
    {
        public TemplateAttributeMap()
        {
            // Primary Key
            this.HasKey(t => t.TemplateAttributeId);

            // Properties
            this.Property(t => t.IsReadOnly)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Caption)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TemplateAttribute");
            this.Property(t => t.TemplateAttributeId).HasColumnName("TemplateAttributeId");
            this.Property(t => t.TemplateId).HasColumnName("TemplateId");
            this.Property(t => t.OrderSequence).HasColumnName("OrderSequence");
            this.Property(t => t.AttributeId).HasColumnName("AttributeId");
            this.Property(t => t.IsReadOnly).HasColumnName("IsReadOnly");
            this.Property(t => t.Caption).HasColumnName("Caption");

            // Relationships
            this.HasRequired(t => t.Attribute)
                .WithMany(t => t.TemplateAttributes)
                .HasForeignKey(d => d.AttributeId);
            this.HasRequired(t => t.Template)
                .WithMany(t => t.TemplateAttributes)
                .HasForeignKey(d => d.TemplateId);

        }
    }
}
