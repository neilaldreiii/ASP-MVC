using ContosoUniversity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ContosoUniversity.DAL
{
    public class SchoolContext : DbContext
    { 
        /*
         * Specifying The Connection String
         */
        public SchoolContext() : base("SchoolContext")
        {

        }

        /*
         * This code creates a DbSet property for each entity set.
         * In Entity Framework terminology, an entity set typically corresponds
         * to a database table, and and entity corresponds to a row in the table
         */
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}