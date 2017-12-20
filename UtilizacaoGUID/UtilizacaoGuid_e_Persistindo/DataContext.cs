using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizacaoGuid_e_Persistindo
{
    public class DataContext : DbContext
    {
        public DataContext() : base("SetDataContext") 
        {
            Database.SetInitializer<DataContext>(new DataContextInitializer());
        }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Mapping());

            base.OnModelCreating(modelBuilder);
        }
        public class DataContextInitializer : DropCreateDatabaseIfModelChanges<DataContext>
        {

        }
    }
}
