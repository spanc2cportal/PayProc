using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PayProc.Models.Mapping
{
    public class ClientTemplateMap : EntityTypeConfiguration<ClientTemplate>
    {
        public ClientTemplateMap()
        {
            // Primary Key
            this.HasKey(t => t.ClientTemplateId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ClientTemplate");
            this.Property(t => t.ClientTemplateId).HasColumnName("ClientTemplateId");
            this.Property(t => t.TemplateId).HasColumnName("TemplateId");
            this.Property(t => t.ClientId).HasColumnName("ClientId");
            this.Property(t => t.PaymentFlowId).HasColumnName("PaymentFlowId");
            this.Property(t => t.PostTypeId).HasColumnName("PostTypeId");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.ClientTemplates)
                .HasForeignKey(d => d.ClientId);
            this.HasRequired(t => t.ClientPostType)
                .WithMany(t => t.ClientTemplates)
                .HasForeignKey(d => d.PostTypeId);
            this.HasRequired(t => t.Template)
                .WithMany(t => t.ClientTemplates)
                .HasForeignKey(d => d.TemplateId);
            this.HasRequired(t => t.PaymentFlow)
                .WithMany(t => t.ClientTemplates)
                .HasForeignKey(d => d.PaymentFlowId);

        }
    }
}
