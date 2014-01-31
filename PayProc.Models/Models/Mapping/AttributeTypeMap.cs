using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PayProc.Models.Mapping
{
    public class AttributeTypeMap : EntityTypeConfiguration<AttributeType>
    {
        public AttributeTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.AttributeTypeId);

            // Properties
            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AttributeType");
            this.Property(t => t.AttributeTypeId).HasColumnName("AttributeTypeId");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
