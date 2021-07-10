using System;
using System.Collections.Generic;
using System.Text;

namespace VitaminGame
{
    class Citrus : FruitClass
    {
    }

    class Orange : Citrus
    {
        public Orange()
        {
            vitA = 225;
            vitC = 45;
            yield = 0.65f;
        }

    }

    class Mandarin : Citrus
    {
        public Mandarin()
        {
            vitA = 681;
            vitC = 26;
            yield = 0.4f;
        }
    }

    class Pomelo : Citrus
    {
        public Pomelo()
        {
            vitA = 3;
            vitC = 44;
            yield = 0.7f;
        }
    }
}
