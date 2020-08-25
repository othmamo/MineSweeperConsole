using System;
using System.Reflection.Emit;

namespace demineur
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int number;
            if(Int32.TryParse(args[0],out number) && Int32.TryParse(args[1],out number))
            {
                var a = new game(Int32.Parse(args[0]),Int32.Parse(args[1]));
                a.ChooseWhatToDO();
            }
        }
    }
}
