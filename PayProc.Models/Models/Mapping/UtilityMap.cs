using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PayProc.Models.Mapping
{
    public class UtilityMap : EntityTypeConfiguration<Utility>
    {
        public UtilityMap()
        {
            // Primary Key
            this.HasKey(t => t.UtilityId);

            // Properties
            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Utility");
            this.Property(t => t.UtilityId).HasColumnName("UtilityId");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.DefaultTemplateId).HasColumnName("DefaultTemplateId");

            // Relationships
            this.HasRequired(t => t.Template)
                .WithMany(t => t.Utilities)
                .HasForeignKey(d => d.DefaultTemplateId);

        }
    }
}
