using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using AdventureWorks.Model.HumanResources;

namespace AdventureWorks.DataAccess.Configurations.HumanResources
{
    internal class JobCandidateConfiguration : EntityTypeConfiguration<JobCandidate>
    {
        public JobCandidateConfiguration()
        {
            ToTable("HumanResources.JobCandidate");
            HasKey(x => x.JobCandidateId);

            Property(x => x.JobCandidateId).HasColumnName("JobCandidateID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.EmployeeId).HasColumnName("EmployeeID").IsOptional();
            Property(x => x.Resume).HasColumnName("Resume").IsOptional();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired();

            // Foreign keys
            HasOptional(a => a.Employee).WithMany(b => b.JobCandidates).HasForeignKey(c => c.EmployeeId); // FK_JobCandidate_Employee_EmployeeID
        }
    }
}