using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.Sales;

namespace AdventureWorks.DataAccess.Configurations.Sales
{
    internal class Sales_SpecialOfferProductConfiguration : EntityTypeConfiguration<Sales_SpecialOfferProduct>
    {
        public Sales_SpecialOfferProductConfiguration()
        {
            ToTable("Sales.SpecialOfferProduct");
            HasKey(x => new { x.ProductId, x.SpecialOfferId });

            Property(x => x.SpecialOfferId).HasColumnName("SpecialOfferID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasRequired(a => a.Sales_SpecialOffer).WithMany(b => b.Sales_SpecialOfferProduct).HasForeignKey(c => c.SpecialOfferId); // FK_SpecialOfferProduct_SpecialOffer_SpecialOfferID
            HasRequired(a => a.Production_Product).WithMany(b => b.Sales_SpecialOfferProduct).HasForeignKey(c => c.ProductId); // FK_SpecialOfferProduct_Product_ProductID
        }
    }
}