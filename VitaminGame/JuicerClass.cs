using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VitaminGame
{
    internal class JuicerClass : IJuicerClass
    {
        public float VitAAmountCalculate(float VitAAmount, float juiceWeight, float vitaminRate)
        {
            VitAAmount = (juiceWeight * vitaminRate) / 100;
            return VitAAmount;
        }

        public float VitCAmountCalculate(float VitCAmount, float juiceWeight, float vitaminRate)
        {
            VitCAmount = (juiceWeight * vitaminRate) / 100;
            return VitCAmount;
        }
    }
}
