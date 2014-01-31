using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PayProc.Models.Mapping
{
    public class UserActivityTypeMap : EntityTypeConfiguration<UserActivityType>
    {
        public UserActivityTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.ActivityTypeId);

            // Properties
            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("UserActivityType");
            this.Property(t => t.ActivityTypeId).HasColumnName("ActivityTypeId");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
