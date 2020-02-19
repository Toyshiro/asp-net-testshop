using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestShop.Models;

namespace TestShop
{
    public class SampleData
    {
        public static void Initialize(ShopContext context)
        {
            if (!context.Products.Any())
            {
                context.Products.AddRange(

                        new Product
                        {
                            Name = "Куриный суп лапша",
                            Description = "Куриный суп лапша",
                            Price = 250
                        },
                        new Product
                        {
                            Name = "Маки с икрой лосося",
                            Description = "Маки с икрой лосося",
                            Price = 110
                        },
                        new Product
                        {
                            Name = "Сашими из лосося",
                            Description = "Сашими из лосося",
                            Price = 340
                        }


                    );
                context.SaveChanges();
            }
        }
    }
}
