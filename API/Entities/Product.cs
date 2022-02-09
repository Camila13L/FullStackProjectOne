using System;
namespace API.Entities
{
    public class Product
    {
        //Ponemos las propiedades
        //All of them are gonna be into our DB 
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public long Price { get; set; } // Long because the DB, the payment procesor

        public string PictureUrl { get; set; }

        public string Type { get; set; }

        public string Brand { get; set; } 

        public int QuantityInStock { get; set; }

        public Product()
        {
        }
    }
}
