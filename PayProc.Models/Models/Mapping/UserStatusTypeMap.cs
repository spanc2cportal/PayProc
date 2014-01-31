using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PayProc.Models.Mapping
{
    public class UserStatusTypeMap : EntityTypeConfiguration<UserStatusType>
    {
        public UserStatusTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.StatusId);

            // Properties
            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("UserStatusType");
            this.Property(t => t.StatusId).HasColumnName("StatusId");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
