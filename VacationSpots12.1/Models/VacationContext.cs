using Microsoft.EntityFrameworkCore;

namespace VacationSpots12._1.Models
{

    //class representing the DB
    public class VacationContext : DbContext
    {

        //constructor
        //invokes base class constructor
        public VacationContext (DbContextOptions <VacationContext> options) : base (options)
        {


        }

         //table 1
         public DbSet<Vacation> Vacations { get; set; }

        //table 2
        public DbSet<Categories> Categories { get; set; }

        //data seeding 
        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Categories>().HasData(

                new Categories { CategoryId = 1, CategoryName = "Backpacking"},
                new Categories { CategoryId = 2, CategoryName = "Outback" },
                new Categories { CategoryId = 3, CategoryName = "City" },
                new Categories { CategoryId = 4, CategoryName = "Island" }

                );

            modelBuilder.Entity<Vacation>().HasData(

                           new Vacation
                           {
                               Id = 1,
                               Name = "Steamy Nights in Marrakech",
                               Days = 10,
                               Description = "Get lost in spices and enjoy the Morrocan vibe",
                               ImageName = "marrakech.jpg",
                               CategoryId = 3,
                               Categories = Category.City,
                               Price = 10000
                             
                               
                           },

                          new Vacation
                          {
                              Id = 2,
                              Name = "Australian Boxing Show",
                              Days = 7,
                              Description = "Get a front seat view watching Kangaroos on their natural habitat",
                              ImageName = "australia.jpg",
                              CategoryId = 2,
                              Categories = Category.Outback,
                              Price = 12000


                          }
                           );
        }
    }
}
