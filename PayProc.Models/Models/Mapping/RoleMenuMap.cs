using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PayProc.Models.Mapping
{
    public class RoleMenuMap : EntityTypeConfiguration<RoleMenu>
    {
        public RoleMenuMap()
        {
            // Primary Key
            this.HasKey(t => new { t.RoleId, t.MenuId });

            // Properties
            this.Property(t => t.IsAllowUpdate)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("RoleMenu");
            this.Property(t => t.RoleId).HasColumnName("RoleId");
            this.Property(t => t.MenuId).HasColumnName("MenuId");
            this.Property(t => t.IsAllowUpdate).HasColumnName("IsAllowUpdate");

            // Relationships
            this.HasRequired(t => t.ApplicationMenu)
                .WithMany(t => t.RoleMenus)
                .HasForeignKey(d => d.MenuId);
            this.HasRequired(t => t.ApplicationRole)
                .WithMany(t => t.RoleMenus)
                .HasForeignKey(d => d.RoleId);

        }
    }
}
