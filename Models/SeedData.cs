using Microsoft.EntityFrameworkCore;
using NotForza.Models;
using NotForza_web_app.Data;
using System;

namespace Downloads.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new CarDataContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<CarDataContext>>()))
        {
            if (context == null || context.Car == null)
            {
                throw new ArgumentNullException("Null RazorPagesMovieContext");
            }

            // Look for any movies.
            if (context.Car.Any())
            {
                return;   // DB has been seeded
            }

            context.Car.AddRange(
                new Car
                {
                    CarName = "Renault",
                    CarModel = "Clio",
                    CarYear = 2020,
                    CarGrade = "S",
                    CarCost = 120000,
                    CarDescription = "A Fast car",
                    CarPicURL = "https://th.bing.com/th/id/OIP.1-R56TgEoD3KKSYEOL2dKwHaFe?w=222&h=180&c=7&r=0&o=5&pid=1.7"
                },

                new Car 
                {
                    CarName = "Toyota",
                    CarModel = "Corolla",
                    CarYear = 2021,
                    CarGrade = "S",
                    CarCost = 150000,
                    CarDescription = "A Fast car",
                    CarPicURL = "https://th.bing.com/th/id/OIP.8FixtTbfNKlrhd6GO30wNwHaEc?w=307&h=184&c=7&r=0&o=5&pid=1.7"
                },

                new Car
                { 
                    CarName = "Honda",
                    CarModel = "Civic",
                    CarYear = 2018,
                    CarGrade = "A",
                    CarCost = 30000,
                    CarDescription = "A Fast car",
                    CarPicURL = "https://th.bing.com/th/id/OIP.ZawJYCjg-sufdu04UwBQCgHaEK?w=1600&h=901&rs=1&pid=ImgDetMain"
                }

               
            );
            context.SaveChanges();
        }
    }
}