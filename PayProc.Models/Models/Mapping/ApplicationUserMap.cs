using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PayProc.Models.Mapping
{
    public class ApplicationUserMap : EntityTypeConfiguration<ApplicationUser>
    {
        public ApplicationUserMap()
        {
            // Primary Key
            this.HasKey(t => t.UserId);

            // Properties
            this.Property(t => t.LoginId)
                .HasMaxLength(100);

            this.Property(t => t.LoginKey)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.IsSysGenerated)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("ApplicationUser");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.UserTypeId).HasColumnName("UserTypeId");
            this.Property(t => t.LoginId).HasColumnName("LoginId");
            this.Property(t => t.LoginKey).HasColumnName("LoginKey");
            this.Property(t => t.KeyChangeTime).HasColumnName("KeyChangeTime");
            this.Property(t => t.IsSysGenerated).HasColumnName("IsSysGenerated");
            this.Property(t => t.FailureCount).HasColumnName("FailureCount");
            this.Property(t => t.StatusId).HasColumnName("StatusId");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.RoleId).HasColumnName("RoleId");
            this.Property(t => t.LastLoginTime).HasColumnName("LastLoginTime");

            // Relationships
            this.HasRequired(t => t.ApplicationRole)
                .WithMany(t => t.ApplicationUsers)
                .HasForeignKey(d => d.RoleId);
            this.HasRequired(t => t.UserStatusType)
                .WithMany(t => t.ApplicationUsers)
                .HasForeignKey(d => d.StatusId);
            this.HasRequired(t => t.UserType)
                .WithMany(t => t.ApplicationUsers)
                .HasForeignKey(d => d.UserTypeId);

        }
    }
}
