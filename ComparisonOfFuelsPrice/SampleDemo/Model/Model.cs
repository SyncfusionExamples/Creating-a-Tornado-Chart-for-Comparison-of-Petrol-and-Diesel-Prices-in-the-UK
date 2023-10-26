using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDemo
{
    public class Model
    {
        public DateTime Date { get; set; }
        public double NegativePetrolPrice { get; set; }
        public double DieselPrice { get; set; }

        public Model(DateTime date, double petrolPrice, double dieselPrice)
        {
            Date = date;
            NegativePetrolPrice = -petrolPrice;
            DieselPrice = dieselPrice;
        }

    }
}
