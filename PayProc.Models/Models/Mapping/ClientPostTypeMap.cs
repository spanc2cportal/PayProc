using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PayProc.Models.Mapping
{
    public class ClientPostTypeMap : EntityTypeConfiguration<ClientPostType>
    {
        public ClientPostTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.PostTypeId);

            // Properties
            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ClientPostType");
            this.Property(t => t.PostTypeId).HasColumnName("PostTypeId");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
