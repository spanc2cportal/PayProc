using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PayProc.Models.Mapping
{
    public class ApplicationRoleMap : EntityTypeConfiguration<ApplicationRole>
    {
        public ApplicationRoleMap()
        {
            // Primary Key
            this.HasKey(t => t.RoleId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Description)
                .HasMaxLength(50);

            this.Property(t => t.IsActive)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("ApplicationRole");
            this.Property(t => t.RoleId).HasColumnName("RoleId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
        }
    }
}
