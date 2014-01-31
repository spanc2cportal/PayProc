using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PayProc.Models.Mapping
{
    public class MemberActivityLogMap : EntityTypeConfiguration<MemberActivityLog>
    {
        public MemberActivityLogMap()
        {
            // Primary Key
            this.HasKey(t => t.LogId);

            // Properties
            this.Property(t => t.Action)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("MemberActivityLog");
            this.Property(t => t.LogId).HasColumnName("LogId");
            this.Property(t => t.LogTime).HasColumnName("LogTime");
            this.Property(t => t.Action).HasColumnName("Action");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.ActivityTypeId).HasColumnName("ActivityTypeId");

            // Relationships
            this.HasRequired(t => t.ApplicationUser)
                .WithMany(t => t.MemberActivityLogs)
                .HasForeignKey(d => d.UserId);
            this.HasRequired(t => t.UserActivityType)
                .WithMany(t => t.MemberActivityLogs)
                .HasForeignKey(d => d.ActivityTypeId);

        }
    }
}
