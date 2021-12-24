using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //Context : Db tabloları ile proje classlarını bağlamak
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = tcp:expertin.database.windows.net; Database = ExpertIn; User ID = ExperInDatabaseRemote; Password = ExpertIn.1; Trusted_Connection = False; Encrypt = True; ");
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ExpertInDatabaseVers2;Trusted_Connection=true");
        }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ApplicationJob> ApplicationJobs { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<FavoriteJob> FavoriteJobs { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<SaveSkill> SaveSkills { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<CurriculumVitae> CurriculumVitaes { get; set; }
    }
}
