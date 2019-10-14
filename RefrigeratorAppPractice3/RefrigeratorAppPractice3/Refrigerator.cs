using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorAppPractice3
{
    class Refrigerator
    {
        public double MaxWeight { get; set; }
        public int NumberOfItems { get; set; }
        public double WeightPerItem { get; set; }


        public double GetCurrentWeight()
        {
            double currentWeight = this.NumberOfItems * this.WeightPerItem;

            return currentWeight;
        }
        public double GetRemainingtWeight()
        {
            double remainingWeight = this.MaxWeight - GetCurrentWeight();

            return remainingWeight;
        }
    }
}
