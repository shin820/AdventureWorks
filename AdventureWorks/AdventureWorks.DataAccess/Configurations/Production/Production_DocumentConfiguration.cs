using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.Production;

namespace AdventureWorks.DataAccess.Configurations.Production
{
    internal class Production_DocumentConfiguration : EntityTypeConfiguration<Production_Document>
    {
        public Production_DocumentConfiguration()
        {
            ToTable("Production.Document");
            HasKey(x => x.DocumentId);

            Property(x => x.DocumentId).HasColumnName("DocumentID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Title).HasColumnName("Title").IsRequired().HasMaxLength(50);
            Property(x => x.FileName).HasColumnName("FileName").IsRequired().HasMaxLength(400);
            Property(x => x.FileExtension).HasColumnName("FileExtension").IsRequired().HasMaxLength(8);
            Property(x => x.Revision).HasColumnName("Revision").IsRequired().HasMaxLength(5);
            Property(x => x.ChangeNumber).HasColumnName("ChangeNumber").IsRequired();
            Property(x => x.Status).HasColumnName("Status").IsRequired();
            Property(x => x.DocumentSummary).HasColumnName("DocumentSummary").IsOptional();
            Property(x => x.Document).HasColumnName("Document").IsOptional();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();
        }
    }
}