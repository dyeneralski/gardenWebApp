using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gardenWebApp.Models
{
    public class Temperature
    {


        public int ID { get; set; }
        public double TemperatureValue { get; set; }
        public DateTime TemperatureDate { get; set; }
    }
}
