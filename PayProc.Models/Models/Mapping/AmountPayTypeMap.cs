using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PayProc.Models.Mapping
{
    public class AmountPayTypeMap : EntityTypeConfiguration<AmountPayType>
    {
        public AmountPayTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.PayTypeId);

            // Properties
            this.Property(t => t.Desctription)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AmountPayType");
            this.Property(t => t.PayTypeId).HasColumnName("PayTypeId");
            this.Property(t => t.Desctription).HasColumnName("Desctription");
        }
    }
}
