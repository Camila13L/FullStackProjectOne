using System;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class StoreContext : DbContext //herencia imort the class
    {
        public StoreContext(DbContextOptions options) : base(options) //Options = DB conxtion string
        {

        }
        public DbSet<Product> Products { get; set;} //Product is the table we are gonna create

    }
}
