using System;
using LegoMiniFigures2.Pieces;
using LegoMiniFigures2.Pieces.Heads;

namespace LegoMiniFigures2
{
    class Program
    {
        static void Main(string[] args)
        {
            var coolHead = new CoolHead();
            coolHead.EyeWear = "Sunglasses";
            coolHead.Hair = "Long";
            coolHead.Gender = Gender.Female;

            var nerdHead = new NerdHead();
            nerdHead.Acne = true;
            nerdHead.Hat = "Fedora";

            //object initializer
            var skull = new Skull {Color = Color.Red, Condition = Condition.OnFire, EyeColor = Color.Green, EyeWear = "Aviators" };

            var heads = new Head[] { coolHead, nerdHead, skull };

            foreach (var head in heads)
            {
                head.Talk("THINGS AND STUFF");
            }






        }
    }
}
