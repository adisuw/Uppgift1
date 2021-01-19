using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift1.Utils
{
    /// <summary>
    /// The UserInputReader class is supposed to be used in the future assignments by extending some of its functions.
    /// It can be used anywhere in the project as it has generic methods with some validations.
    /// </summary>
    class UserInputReader
    {
        /*
         * Reads a string and returns to the caller
         */
        public static string ReadString()
        {
            Console.Write("Please Enter name: ");
            return Console.ReadLine();
        }
        /*
         * Reads a string value from console and returns adouble
         * if the string is parseable, then it returns the parsed double
         * otherwise it returns a default value 0.0
         *
         */
        public static double ReadDouble()
        {
            Console.Write("Please enter salary: ");
            string number = Console.ReadLine();
            return IsParseable(number) ? double.Parse(number) : 0.0;
        }
        /*
         * if the double value is greater than zero then
         * consider it as valued
         */
        public static bool IsValidDouble(double value)
        {
            return value >= 0;
        }

        public static bool IsParseable(string number)
        {
            double res = 0.0;
            return (double.TryParse(number, out res));
        }

        /*
         * reads a string and parses it
         * if successful then return the input
         * otherwise return default value 0.
         */
        public static int ReadInt()
        {
            var i = 0;
            Console.Write("Please Enter id: ");
            var number = Console.ReadLine();
            return int.TryParse(number, out i) ? i : 0;
        }
    }
}
