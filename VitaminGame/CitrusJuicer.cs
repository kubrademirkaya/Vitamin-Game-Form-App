using System;
using System.Collections.Generic;
using System.Text;

namespace VitaminGame
{
    class CitrusJuicer : JuicerClass
    {
        public float LiquidWeightCalculate(float liquidWeight, int weight, float yield)
        {
            liquidWeight = weight * yield;
            return liquidWeight;
        }
    }
}
