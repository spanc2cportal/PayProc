using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PayProc.Models.Mapping
{
    public class ClientMap : EntityTypeConfiguration<Client>
    {
        public ClientMap()
        {
            // Primary Key
            this.HasKey(t => t.ClientId);

            // Properties
            // Table & Column Mappings
            this.ToTable("Client");
            this.Property(t => t.ClientId).HasColumnName("ClientId");
            this.Property(t => t.BillerId).HasColumnName("BillerId");
            this.Property(t => t.ClientTypeId).HasColumnName("ClientTypeId");

            // Relationships
            this.HasRequired(t => t.Biller)
                .WithMany(t => t.Clients)
                .HasForeignKey(d => d.BillerId);
            this.HasRequired(t => t.ClientType)
                .WithMany(t => t.Clients)
                .HasForeignKey(d => d.ClientTypeId);

        }
    }
}
