using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurOtomasyonu.Mappings;

namespace TurOtomasyonu.Models
{
    public class ProjectContext:DbContext
    {
        public ProjectContext():base("name=TurConn")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ProjectContext>());
        }

        public DbSet<TourCategory> TourCategories { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<Customer> Customers { get; set; }
        //satın alma işleminden sonra
        public DbSet<CustomerTourHistory> Histories { get; set; }

        public DbSet<Comment> Comment { get; set; }

        public DbSet<Vote> Vote { get; set; }


        //FLUENT API
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMapping());
            modelBuilder.Configurations.Add(new CustomerProfileMapping());
            modelBuilder.Configurations.Add(new CustomerTourHistoryMapping());
            modelBuilder.Configurations.Add(new TourCategoryMapping());
            modelBuilder.Configurations.Add(new TourMapping());
            modelBuilder.Configurations.Add(new CommentMapping());
            modelBuilder.Configurations.Add(new VoteMapping());
        }
    }

}
