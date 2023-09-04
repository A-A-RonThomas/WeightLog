using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightLog.Models
{
    public class WeightList
    {
        private readonly List<Weight> weightList;

        public WeightList()
        {
            weightList = new List<Weight>();
        }

        public void addWeight(Weight weight) 
        {
            if(weightList.Count - 1 >= 0)
            {
                Weight lastEntered = weightList[weightList.Count - 1];
                if (lastEntered != null)
                {
                    weight.Percentage = (weight.WeightNum - lastEntered.WeightNum) / lastEntered.WeightNum * 100;
                }
            }
                
            weightList.Add(weight);
        }

        public override string ToString()
        {
            string built = "";
            foreach (Weight weight in weightList)
            {
                built += weight.ToString();
            }

            return built;
        }

        public List<Weight> GetWeights()
        {
            return weightList;
        }
    }
}
