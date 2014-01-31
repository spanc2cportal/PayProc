using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PayProc.Models.Mapping
{
    public class AlertTypeMap : EntityTypeConfiguration<AlertType>
    {
        public AlertTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.AlertTypeId);

            // Properties
            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AlertType");
            this.Property(t => t.AlertTypeId).HasColumnName("AlertTypeId");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
