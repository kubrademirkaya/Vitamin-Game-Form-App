using System;
using System.Collections.Generic;
using System.Text;

namespace VitaminGame
{
    class SolidFruit : FruitClass
    {
    }

    class Apple : SolidFruit
    {
        public Apple()
        {
            vitA = 54;
            vitC = 5;
            yield = 0.85f;
        }
    }

    class Strawberry : SolidFruit
    {
        public Strawberry()
        {
            vitA = 12;
            vitC = 60;
            yield = 0.8f;
        }
    }

    class Pear : SolidFruit
    {
        public Pear()
        {
            vitA = 25;
            vitC = 5;
            yield = 0.95f;
        }
    }

}

