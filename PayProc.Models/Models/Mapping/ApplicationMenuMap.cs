using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PayProc.Models.Mapping
{
    public class ApplicationMenuMap : EntityTypeConfiguration<ApplicationMenu>
    {
        public ApplicationMenuMap()
        {
            // Primary Key
            this.HasKey(t => t.MenuId);

            // Properties
            this.Property(t => t.GroupName)
                .HasMaxLength(30);

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
            this.ToTable("ApplicationMenu");
            this.Property(t => t.MenuId).HasColumnName("MenuId");
            this.Property(t => t.GroupName).HasColumnName("GroupName");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
        }
    }
}
