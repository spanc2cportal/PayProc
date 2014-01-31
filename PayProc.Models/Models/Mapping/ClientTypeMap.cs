using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PayProc.Models.Mapping
{
    public class ClientTypeMap : EntityTypeConfiguration<ClientType>
    {
        public ClientTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.ClientTypeId);

            // Properties
            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ClientType");
            this.Property(t => t.ClientTypeId).HasColumnName("ClientTypeId");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
