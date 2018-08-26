using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gardenApp.Models
{
    public class Temperature
    {
        public int ID { get; set; }
        public double TemperatureValue { get; set; }
        public DateTime TemperatureDate { get; set; }
    }
}
