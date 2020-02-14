using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BackEnd_Final_Project.Models;

namespace BackEnd_Final_Project.Data
{
   public class LibraryDbContext:DbContext
    {
       

        public LibraryDbContext() : base("BookLibrary")
        {

        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Manager> Managers { get; set; }

        public DbSet<Report> Reports { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public  DbSet<Author> Authors { get; set; }

    }


   
}
