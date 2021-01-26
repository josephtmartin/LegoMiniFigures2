﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigures2.Pieces.Heads
{
    class CoolHead : Head
    {
        public string Hair { get; set; }
        public Gender Gender { get; set; }

        public void Chill()
        {
            Console.WriteLine($"The {Gender} head with {Hair} hair is wearing {EyeWear} and chilling.");
        }

        public override void Greet()
        {
            Console.WriteLine($"The {Gender} head with {Hair} hair is wearing {EyeWear} and says 'sup brah'");
        }

    }
}
