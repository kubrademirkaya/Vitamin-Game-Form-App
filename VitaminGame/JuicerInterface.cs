using System;
using System.Collections.Generic;
using System.Text;

namespace VitaminGame
{
    interface IJuicerClass
    {
        public float VitAAmountCalculate(float VitAAmount, float juiceWeight, float vitaminRate);

        public float VitCAmountCalculate(float VitCAmount, float juiceWeight, float vitaminRate);

    }
}
