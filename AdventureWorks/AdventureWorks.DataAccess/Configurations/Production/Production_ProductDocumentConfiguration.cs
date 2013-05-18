using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.Production;

namespace AdventureWorks.DataAccess.Configurations.Production
{
    internal class Production_ProductDocumentConfiguration : EntityTypeConfiguration<Production_ProductDocument>
    {
        public Production_ProductDocumentConfiguration()
        {
            ToTable("Production.ProductDocument");
            HasKey(x => new { x.DocumentId, x.ProductId });

            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.DocumentId).HasColumnName("DocumentID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Production_Product).WithMany(b => b.Production_ProductDocument).HasForeignKey(c => c.ProductId); // FK_ProductDocument_Product_ProductID
            HasRequired(a => a.Production_Document).WithMany(b => b.Production_ProductDocument).HasForeignKey(c => c.DocumentId); // FK_ProductDocument_Document_DocumentID
        }
    }
}