using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigures2.Pieces.Heads
{
    class Skull : Head
    {
        public Condition Condition { get; set; }
        public Color Color { get; set; }

        public void Wail()
        {
            if (Condition == Condition.OnFire)
            {
                Console.WriteLine($"The flaming {Color} skull with {EyeColor} eyes wails angrily.");
            }
            else
            {
                Console.WriteLine($"The {Color} skull wails mournfully because it is dead {Condition} and not on fire");
            }
        }

        public override void Greet()
        {
            if (Condition == Condition.OnFire)
            {
                Console.WriteLine($"The flaming {Color} skull with {EyeColor} eyes smolders in your direction");
            }
            else
            {
                Console.WriteLine($"The {Color} skull is dead and can't greet you.");
            }
        }
    }
}
