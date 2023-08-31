using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightLog.Models
{
    public class Weight
    {

        public double WeightNum { get; }

        public DateTime Date { get; }

        public double? Percentage { get; set; }

        public Weight(double weightNum, DateTime date)
        {
            WeightNum = weightNum;
            Date = date;
        }

        public bool Equals(Weight weight) => WeightNum == weight.WeightNum &&
                Date == weight.Date;

        public override string ToString()
        {
            return "Weight: " + WeightNum.ToString();
        }
    }
}
