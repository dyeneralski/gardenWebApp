using System;
using gardenWebApp.Models;

namespace gardenApp.Data
{
    public class DbSeeder
    {
        public DbSeeder()
        {
        }

        public static void Seed(TemperatureContext dbContext)
        {
            //if (!dbContext.Temperature.Any()) CreateTemperatures(dbContext);
            CreateTemperatures(dbContext);
        }

        private static void CreateTemperatures(TemperatureContext dbContext)
        {
            DateTime tempDate = new DateTime(2018, 03, 01, 12, 30, 00);

            var temp = new Temperature()
            {
                ID = 1,
                TemperatureValue = 16.9,
                TemperatureDate = tempDate
            };
            dbContext.Temperature.Add(temp);
            dbContext.SaveChanges();

        }
    }
}
