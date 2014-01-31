using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PayProc.Models.Mapping
{
    public class UserAlertMap : EntityTypeConfiguration<UserAlert>
    {
        public UserAlertMap()
        {
            // Primary Key
            this.HasKey(t => new { t.UserId, t.AlertTypeId });

            // Properties
            this.Property(t => t.UserId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("UserAlert");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.AlertTypeId).HasColumnName("AlertTypeId");
            this.Property(t => t.UserId1).HasColumnName("UserId1");

            // Relationships
            this.HasRequired(t => t.AlertType)
                .WithMany(t => t.UserAlerts)
                .HasForeignKey(d => d.AlertTypeId);
            this.HasRequired(t => t.ApplicationUser)
                .WithMany(t => t.UserAlerts)
                .HasForeignKey(d => d.UserId);

        }
    }
}
