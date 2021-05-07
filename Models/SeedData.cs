using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace FinalProjectCIDM3312.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ShoeDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ShoeDbContext>>()))
                {
                    if(context.Shoe.Any())
                    {
                        return;
                    }

                    context.Shoe.AddRange(
                        new Shoe
                        {
                            Size = 10,
                            Color = "Red",
                            Brand = "Nike"
                        },
                        new Shoe
                        {
                            Size = 11.5,
                            Color = "Black",
                            Brand = "Nike"
                        },
                        new Shoe
                        {
                            Size = 9,
                            Color = "White",
                            Brand = "Addidas"
                        },
                        new Shoe
                        {
                            Size = 8.5,
                            Color = "Blue/White",
                            Brand = "New Balance"
                        },
                        new Shoe
                        {
                            Size = 6,
                            Color = "White",
                            Brand = "Nike"
                        },
                        new Shoe
                        {
                            Size = 7,
                            Color = "Black",
                            Brand = "Fila"
                        },
                        new Shoe
                        {
                            Size = 8,
                            Color = "Pink",
                            Brand = "Addidas"
                        },
                        new Shoe
                        {
                            Size = 11,
                            Color = "Red",
                            Brand = "Steve Madden"
                        },
                        new Shoe
                        {
                            Size = 5,
                            Color = "Green",
                            Brand = "Steve Madden"
                        },
                        new Shoe
                        {
                            Size = 9,
                            Color = "Purple",
                            Brand = "New Balance"
                        }
                    );
                    
                    context.SaveChanges();
                }
        
            using (var context = new ShirtDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ShirtDbContext>>()))
                {
                    if(context.Shirt.Any())
                    {
                        return;
                    }

                    context.Shirt.AddRange(
                        new Shirt
                        {
                            TSize = "M",
                            TColor = "Red",
                            TBrand = "Addidas",
                            TDesign = "Strips"
                        },
                        new Shirt
                        {
                            TSize = "L",
                            TColor = "Purple",
                            TBrand = "Nike",
                            TDesign = "Spotted"
                        },
                        new Shirt
                        {
                            TSize = "S",
                            TColor = "Green",
                            TBrand = "PacSun",
                            TDesign = "Circles"
                        },
                        new Shirt
                        {
                            TSize = "M",
                            TColor = "Black/Blue",
                            TBrand = "Fruit Of The Loom",
                            TDesign = "Plain"
                        },
                        new Shirt
                        {
                            TSize = "L",
                            TColor = "Gray/Black",
                            TBrand = "Comfort Colors",
                            TDesign = "Star"
                        },
                        new Shirt
                        {
                            TSize = "S",
                            TColor = "Pink",
                            TBrand = "Addidas",
                            TDesign = "Smily Face"
                        },
                        new Shirt
                        {
                            TSize = "XL",
                            TColor = "Blue",
                            TBrand = "Nike",
                            TDesign = "Turtle"
                        },
                        new Shirt
                        {
                            TSize = "M",
                            TColor = "White",
                            TBrand = "Under Armor",
                            TDesign = "Flower"
                        }
                    );
                    
                    context.SaveChanges();
                }
        }
        public int ShoeId {get; set;}

        public int Size {get; set;}
        public string Brand {get; set;}
        public string Color {get; set;}
        public int ShirtId {get; set;}

        public double TSize {get; set;}
        public string TBrand {get; set;}
        public string TColor {get; set;}
        public string TDesign  {get; set;}
    }
}