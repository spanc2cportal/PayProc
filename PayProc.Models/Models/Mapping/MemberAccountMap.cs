using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PayProc.Models.Mapping
{
    public class MemberAccountMap : EntityTypeConfiguration<MemberAccount>
    {
        public MemberAccountMap()
        {
            // Primary Key
            this.HasKey(t => t.AccountId);

            // Properties
            this.Property(t => t.FirstName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.MiddleName)
                .HasMaxLength(100);

            this.Property(t => t.LastName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.AddressLine1)
                .HasMaxLength(100);

            this.Property(t => t.AddressLine2)
                .HasMaxLength(100);

            this.Property(t => t.City)
                .HasMaxLength(100);

            this.Property(t => t.ZipCode)
                .HasMaxLength(100);

            this.Property(t => t.Phone)
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("MemberAccount");
            this.Property(t => t.AccountId).HasColumnName("AccountId");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.MiddleName).HasColumnName("MiddleName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.AddressLine1).HasColumnName("AddressLine1");
            this.Property(t => t.AddressLine2).HasColumnName("AddressLine2");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.ZipCode).HasColumnName("ZipCode");
            this.Property(t => t.StateId).HasColumnName("StateId");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.CreatedTime).HasColumnName("CreatedTime");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.ModifiedTime).HasColumnName("ModifiedTime");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");

            // Relationships
            this.HasRequired(t => t.ApplicationUser)
                .WithMany(t => t.MemberAccounts)
                .HasForeignKey(d => d.UserId);
            this.HasOptional(t => t.State)
                .WithMany(t => t.MemberAccounts)
                .HasForeignKey(d => d.StateId);

        }
    }
}
