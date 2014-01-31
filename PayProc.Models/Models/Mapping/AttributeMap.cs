using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PayProc.Models.Mapping
{
    public class AttributeMap : EntityTypeConfiguration<Attribute>
    {
        public AttributeMap()
        {
            // Primary Key
            this.HasKey(t => t.AttributeId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Attribute");
            this.Property(t => t.AttributeId).HasColumnName("AttributeId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Precision).HasColumnName("Precision");
            this.Property(t => t.Scale).HasColumnName("Scale");
            this.Property(t => t.AttributeTypeId).HasColumnName("AttributeTypeId");

            // Relationships
            this.HasRequired(t => t.AttributeType)
                .WithMany(t => t.Attributes)
                .HasForeignKey(d => d.AttributeTypeId);

        }
    }
}
