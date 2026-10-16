using System;
using System.Collections.Generic;
using System.Text;

namespace Hristograma
{
    public class View
    {
        public int Num { get; set; }
        public double P1 { get; set; }
        public double P2 { get; set; }
        public double P3 { get; set; }
        public double P4 { get; set; }
        public double P5 { get; set; }

        public void InputInfo()
        {
            Console.Write("Enter number: ");
            Num = int.Parse(Console.ReadLine());

        }

        public void OutputInfo()
        {
            Console.WriteLine($"{P1 * 100 / Num:F2}%");
            Console.WriteLine($"{P2 * 100 / Num:F2}%");
            Console.WriteLine($"{P3 * 100 / Num:F2}%");
            Console.WriteLine($"{P4 * 100 / Num:F2}%");
            Console.WriteLine($"{P5 * 100 / Num:F2}%");
        }
    }
}
