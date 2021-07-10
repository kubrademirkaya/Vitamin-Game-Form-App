using System;
using System.Collections.Generic;
using System.Text;

namespace VitaminGame
{
    class SolidFruitJuicer : JuicerClass
    {
        public float PureeWeightCalculate(float pureeWeight, int weight, float yield)
        {
            pureeWeight = weight * yield;
            return pureeWeight;
        }
    }
}
