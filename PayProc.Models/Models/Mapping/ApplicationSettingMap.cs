using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PayProc.Models.Mapping
{
    public class ApplicationSettingMap : EntityTypeConfiguration<ApplicationSetting>
    {
        public ApplicationSettingMap()
        {
            // Primary Key
            this.HasKey(t => t.SettingId);

            // Properties
            this.Property(t => t.DisclaimerPath)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.PrivacyPolicyPath)
                .HasMaxLength(250);

            this.Property(t => t.TermsPath)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("ApplicationSetting");
            this.Property(t => t.SettingId).HasColumnName("SettingId");
            this.Property(t => t.DisclaimerPath).HasColumnName("DisclaimerPath");
            this.Property(t => t.PrivacyPolicyPath).HasColumnName("PrivacyPolicyPath");
            this.Property(t => t.TermsPath).HasColumnName("TermsPath");
        }
    }
}
