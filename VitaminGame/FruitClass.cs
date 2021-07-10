using System;
using System.Collections.Generic;
using System.Text;

namespace VitaminGame
{
    class FruitClass : IFruitClass
    {

        public int vitA { get; set; }
        public int vitC { get; set; }
        public int weight { get; set; }
        public float yield { get; set; }

        public int RandomWeightCalculate(int weight)
        {
            Random random = new Random();
            weight = random.Next(70, 120);
            return weight;
        }

        
    }
}
