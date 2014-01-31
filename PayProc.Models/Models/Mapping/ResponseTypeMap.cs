using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PayProc.Models.Mapping
{
    public class ResponseTypeMap : EntityTypeConfiguration<ResponseType>
    {
        public ResponseTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.ResponseTypeId);

            // Properties
            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ResponseType");
            this.Property(t => t.ResponseTypeId).HasColumnName("ResponseTypeId");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
