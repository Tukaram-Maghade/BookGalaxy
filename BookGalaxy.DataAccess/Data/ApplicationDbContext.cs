using BookGalaxy.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookGalaxy.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 },
                new Category { Id = 4, Name="Novel", DisplayOrder=4 }
                );

            modelBuilder.Entity<Product>().HasData(
               new Product
               {
                   Id = 1,
                   Title = "Mrutyunjay",
                   Author = "Shivaji Sawant",
                   Description = "Karn, the Suryaputra (Son of God) who spends his whole life being mocked as Sutputra. Karn, the Jayshtha Kauntya(Eldest Son of Kunti, the queen mother) who is better known as Radhay. Karn who was equally admired and loved by Panchali (The Empress) and Vrishaali. Karn, the invincible, born with a sheath which could never be penetrated is the most soft hearted philanthropist;Karn,the one who never returned anybody from his door empty handed but could never fill up his own hands .",
                   ISBN = "CAW777777701",
                   ListPrice = 600,
                   Price = 550,
                   Price50 = 500,
                   Price100 = 500,
                   CategoryId = 3,
                   ImageUrl = ""
               },
               new Product
               {
                   Id = 2,
                   Title = "Revolution 2020",
                   Author = "Chetan Bhagat",
                   Description = "novel by Chetan Bhagat. Its story is concerned with a love triangle, corruption and a journey of self-discovery. R2020 has addressed the issue of how private coaching institutions exploit aspiring engineering students and how parents put their lifetime's earnings on stake for these classes so that their children can crack engineering exams and change the fortune of the family ",
                   ISBN = "CAW777777702",
                   ListPrice = 200,
                   Price = 190,
                   Price50 = 180,
                   Price100 = 180,
                   CategoryId = 4,
                   ImageUrl = ""
               },
               new Product
               {
                   Id = 3,
                   Title = "Kim",
                   Author = "Rudyard Kipling",
                   Description = "It is set after the Second Afghan War (which ended in 1881), but before the Third (fought in 1919), probably in the period 1893 to 1898.[2] The novel is notable for its detailed portrait of the people, culture, and varied religions of India. \"The book presents a vivid picture of India, its teeming populations, religions, and superstitions, and the life of the bazaars and the road.",
                   ISBN = "RITO5555501",
                   ListPrice = 550,
                   Price = 500,
                   Price50 = 550,
                   Price100 = 500,
                   CategoryId = 1,
                   ImageUrl=""

               },
               new Product
               {
                   Id = 4,
                   Title = "Secrets of Mind Power",
                   Author = "Harry Lorayne",
                   Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                   ISBN = "WS3333333301",
                   ListPrice = 220,
                   Price = 200,
                   Price50 = 190,
                   Price100 = 190,
                   CategoryId = 2,
                   ImageUrl = ""
               },
               new Product
               {
                   Id = 5,
                   Title = " Indian Polity ",
                   Author = "M Laxmikanth",
                   Description = "McGraw Hill presents the seventh edition of the consistent best seller and the most celebrated title on the subject – Indian Polity by M Laxmikanth. The book is a must-read for the aspirants appearing for the UPSC – Civil Services Examination as well as the other State Services examinations. It is conceived to cater to the requirements of not just the students appearing for competitive examinations but also postgraduates, research scholars, academicians and general readers who are interested in the country’s political, civil, and constitutional issues. The chapters have been thoroughly revised as per the recent developments with an addition of 12 new chapters in this latest edition.",
                   ISBN = "SOTJ1111111101",
                   ListPrice = 800,
                   Price = 800,
                   Price50 = 750,
                   Price100 = 700,
                   CategoryId = 2,
                   ImageUrl = ""
               },
               new Product
               {
                   Id = 6,
                   Title = "Gravity from the Ground Up",
                   Author = "Bernard Schutz",
                   Description = "An accessible introduction to astronomy and general relativity, using only high-school level mathematics to explain the laws of physics governing gravity. Suitable as a university textbook for introductory physics and astronomy courses, the book will also be of interest to general readers wishing to understand the workings of our universe. ",
                   ISBN = "FOT000000001",
                   ListPrice = 5999,
                   Price = 5999,
                   Price50 = 5555,
                   Price100 = 5550,
                   CategoryId = 2,
                   ImageUrl = ""
               }
               );
        }
    }
}
