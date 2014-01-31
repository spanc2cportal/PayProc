using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PayProc.Models.Mapping
{
    public class StateMap : EntityTypeConfiguration<State>
    {
        public StateMap()
        {
            // Primary Key
            this.HasKey(t => t.StateId);

            // Properties
            this.Property(t => t.StateId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Code)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("State");
            this.Property(t => t.StateId).HasColumnName("StateId");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
