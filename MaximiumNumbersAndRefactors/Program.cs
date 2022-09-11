using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximiumNumbersAndRefactors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose option 1.IntergerMaxNumb");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    IntegerMaximumNumber integerMaximumNumber = new IntegerMaximumNumber();
                    int value = integerMaximumNumber.PrintMaximumNumber(89, 40, 90);
                    Console.WriteLine("Maximum number of integer is " + value);
                    break;

                    Console.ReadLine();
            }
        }
    }
}
