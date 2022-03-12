using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Flyweight
{
    /// <summary>
    /// A 'ConcreteFlyweight' class
    /// </summary>
    public class CharacterA : Character
    {
        // Constructor
        public CharacterA()
        {
            symbol = 'A';
            height = 100;
            width = 120;
            ascent = 70;
            descent = 0;
        }
        public override void Display(int pointSize)
        {
            this.pointSize = pointSize;
            Console.WriteLine(symbol +
                " (pointsize " + this.pointSize + ")");
        }
    }
}
