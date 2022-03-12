using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Flyweight
{
    /// <summary>
    /// A 'ConcreteFlyweight' class
    /// </summary>
    public class CharacterB : Character
    {
        // Constructor
        public CharacterB()
        {
            symbol = 'B';
            height = 100;
            width = 140;
            ascent = 72;
            descent = 0;
        }
        public override void Display(int pointSize)
        {
            this.pointSize = pointSize;
            Console.WriteLine(this.symbol +
                " (pointsize " + this.pointSize + ")");
        }
    }
}
