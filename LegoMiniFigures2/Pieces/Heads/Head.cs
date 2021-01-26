using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigures2.Pieces.Heads
{
    //Base Class
    //Abstract class can't be instantiated
    //They can only inherit from
    abstract class Head
    {
        public Color EyeColor { get; set; }
        public string EyeWear { get; set; }

        //No implementation, only allowed on abstract classes
        public abstract void Greet();
        public void Talk(string wordsToSay)
        {
            Greet();
            Console.WriteLine($"The {GetType().Name} says '{wordsToSay}'");
        }
    }
}
