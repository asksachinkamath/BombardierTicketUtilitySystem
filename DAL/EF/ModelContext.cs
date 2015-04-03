using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DAL
{


    public class BombardierUtilityDBInitializer : CreateDatabaseIfNotExists<ModelContext>
    {
        List<UserDetailTbl> Users = new List<UserDetailTbl>();
        List<CategoryTbl> categories = new List<CategoryTbl>();
       

        public BombardierUtilityDBInitializer()
        {
            Users.Add(new UserDetailTbl { UserName = "Ananthvittal Kamath", PSA = "115846", Email = "ananthvittal.kamath@cgi.com", PassWord = "password123", DateCreated = DateTime.Now.Date, Role = "admin" });
            Users.Add(new UserDetailTbl { UserName = "Amalin Chatterjee", PSA = "112600", Email = "amamlin.chatterjee@cgi.com", PassWord = "password123", DateCreated = DateTime.Now.Date, Role = "user" });
            Users.Add(new UserDetailTbl { UserName = "Madhan Seran", PSA = "076713", Email = "madhan.s@cgi.com", PassWord = "password123", DateCreated = DateTime.Now.Date, Role = "user" });

            categories.Add(new CategoryTbl { CategoryName = "Department" });
            categories.Add(new CategoryTbl { CategoryName = "Finance" });
            categories.Add(new CategoryTbl { CategoryName = "Sales" });

         
        }



        protected override void Seed(ModelContext context)
        {
            foreach (UserDetailTbl u in Users)
            {
                context.UserDetails.Add(u);
            }

            foreach (CategoryTbl c in categories)
            {
                context.Categories.Add(c);
            }

            context.SaveChanges();
            base.Seed(context);
        }
    }


    public class ModelContext : DbContext
    {
        public ModelContext()
            : base("BombardierUtility")
        {
            Database.SetInitializer<ModelContext>(new BombardierUtilityDBInitializer());

            //Database.SetInitializer<SchoolDBContext>(new DropCreateDatabaseIfModelChanges<SchoolDBContext>());
            //Database.SetInitializer<SchoolDBContext>(new DropCreateDatabaseAlways<SchoolDBContext>());
            //Database.SetInitializer<SchoolDBContext>(new SchoolDBInitializer());
        }
        public DbSet<UserDetailTbl> UserDetails { get; set; }
        public DbSet<CategoryTbl> Categories { get; set; }
        public DbSet<ApplicationTbl> Applications { get; set; }

       

        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }



    }
}
