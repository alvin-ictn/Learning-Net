using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_with_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int intData = 99; // use to declare integer number
            double doubleData = 10.55; // use to declare deciaml number
            string stringData = "Hello C#"; // use to declare character or string

            Console.WriteLine(stringData + " " + doubleData + " " + intData);
            Console.ReadLine();
        }
    }
}
