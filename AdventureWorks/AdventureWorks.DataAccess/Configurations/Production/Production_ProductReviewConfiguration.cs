using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.Production;

namespace AdventureWorks.DataAccess.Configurations.Production
{
    internal class Production_ProductReviewConfiguration : EntityTypeConfiguration<Production_ProductReview>
    {
        public Production_ProductReviewConfiguration()
        {
            ToTable("Production.ProductReview");
            HasKey(x => x.ProductReviewId);

            Property(x => x.ProductReviewId).HasColumnName("ProductReviewID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired();
            Property(x => x.ReviewerName).HasColumnName("ReviewerName").IsRequired().HasMaxLength(50);
            Property(x => x.ReviewDate).HasColumnName("ReviewDate").IsRequired();
            Property(x => x.EmailAddress).HasColumnName("EmailAddress").IsRequired().HasMaxLength(50);
            Property(x => x.Rating).HasColumnName("Rating").IsRequired();
            Property(x => x.Comments).HasColumnName("Comments").IsOptional().HasMaxLength(3850);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Production_Product).WithMany(b => b.Production_ProductReview).HasForeignKey(c => c.ProductId); // FK_ProductReview_Product_ProductID
        }
    }
}