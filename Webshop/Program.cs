﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Webshop.Models;

namespace Webshop
{
    public class Program
    {
        public static void Main(string[] args){
        {
//             using (var db = new ProductContext())
// {

//   Categorie c = new Categorie
//   {
//     Name = "Drones",
//     Products = new System.Collections.Generic.List<Product> {
//       new Product{Title = "DJI Phantom", CategorieId = 1, Image = "~/images/djiphantom.jpg"},
//       new Product{Title = "DJI Spark", CategorieId = 1}
//     }
//   };
//   db.Categories.Add(c);
//   db.SaveChanges();
// }

            BuildWebHost(args).Run();
        }
        } 

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
