using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PayProc.Models.Mapping
{
    public class FeedbackMap : EntityTypeConfiguration<Feedback>
    {
        public FeedbackMap()
        {
            // Primary Key
            this.HasKey(t => t.FeedbackId);

            // Properties
            this.Property(t => t.FeedbackId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FeedbackText)
                .HasMaxLength(2000);

            this.Property(t => t.FeedbackMailId)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Feedback");
            this.Property(t => t.FeedbackId).HasColumnName("FeedbackId");
            this.Property(t => t.FeedbackText).HasColumnName("FeedbackText");
            this.Property(t => t.FeedbackTime).HasColumnName("FeedbackTime");
            this.Property(t => t.FeedbackMailId).HasColumnName("FeedbackMailId");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.ResponseTypeId).HasColumnName("ResponseTypeId");
            this.Property(t => t.ResponseTs).HasColumnName("ResponseTs");
            this.Property(t => t.RespondedBy).HasColumnName("RespondedBy");

            // Relationships
            this.HasOptional(t => t.ApplicationUser)
                .WithMany(t => t.Feedbacks)
                .HasForeignKey(d => d.UserId);
            this.HasOptional(t => t.ApplicationUser1)
                .WithMany(t => t.Feedbacks1)
                .HasForeignKey(d => d.RespondedBy);
            this.HasRequired(t => t.ResponseType)
                .WithMany(t => t.Feedbacks)
                .HasForeignKey(d => d.ResponseTypeId);

        }
    }
}
