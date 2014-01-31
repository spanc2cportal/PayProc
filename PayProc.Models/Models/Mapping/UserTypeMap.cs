using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PayProc.Models.Mapping
{
    public class UserTypeMap : EntityTypeConfiguration<UserType>
    {
        public UserTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.UserTypeId);

            // Properties
            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("UserType");
            this.Property(t => t.UserTypeId).HasColumnName("UserTypeId");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
