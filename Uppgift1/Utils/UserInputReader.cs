using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift1.Utils
{
    class UserInputReader
    {
        public static string ReadString()
        {
            Console.Write("Please Enter name: ");
            return Console.ReadLine();
        }

        public static double ReadDouble()
        {
            Console.Write("Please enter salary: ");
            string number = Console.ReadLine();
            return IsParseable(number) ? double.Parse(number) : 0.0;
        }
        public static bool IsValidDouble(double value)
        {
            return value >= 0;
        }

        public static bool IsParseable(string number)
        {
            double res = 0.0;
            return (double.TryParse(number, out res));
        }

        public static int ReadInt()
        {
            int i = 0;
            Console.Write("Please Enter id: ");
            string number = Console.ReadLine();
            if (int.TryParse(number, out i))
            {
                return i;
            }

            return i;
        }
    }
}
