// A C# console app that converts an RGB to a HEX trplet
// Not the most efficient algorithm, as it was built with the purpose of learning arrays and loops

using System;

namespace ConverToHex
{
    class Program
    {
        static void Main(string[] args)
        {
            var rgb = new Byte[3];
            
            Console.Write("Red: ");
            rgb[0] = Convert.ToByte(Console.ReadLine());

            Console.Write("Green: ");
            rgb[1] = Convert.ToByte(Console.ReadLine());

            Console.Write("Blue: ");
            rgb[2] = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("rgb( {0}, {1}, {2} )", rgb[0], rgb[1], rgb[2]);

            string[] base16 = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };

            string triplet = "#";

            foreach (byte b in rgb)
            {
                var q = b / 16;
                var r = b - (q * 16);
                string writer = base16[r];
                var n = q;

                while (q > 0)
                {
                    q = n / 16;
                    r = n - (q * 16);
                    writer = base16[r] + writer;
                }

                if (writer.Length == 1)
                {
                    writer = "0" + writer;
                }
                triplet = triplet + writer;
            }
            Console.WriteLine(triplet);
            Console.ReadKey();
        }
    }
}
