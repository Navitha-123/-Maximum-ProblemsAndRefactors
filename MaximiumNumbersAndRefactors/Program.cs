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
            Console.WriteLine("Choose option 1.IntergerMaxNumb \t 2.FloatMaxNum \t 3.Stringmax");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    IntegerMaximumNumber integerMaximumNumber = new IntegerMaximumNumber();
                    int value = integerMaximumNumber.PrintMaximumNumber(89, 40, 90);
                    Console.WriteLine("Maximum number of integer is " + value);
                    break;
                case 2:
                    FloatMaxNumber floatMaxNumber = new FloatMaxNumber();
                    int  Floatvalue = (int)floatMaxNumber.PrintFloatMaximumNumber(6.3f,4.05f,3.4f);
                    Console.WriteLine("Maximum number of Float is " + Floatvalue);
                    break;
                case 3:
                    StringsMaximum stringsMaximum = new StringsMaximum();
                    String strvalue = stringsMaximum.PrintMaximumString("navitha", "Apple", "water");
                    Console.WriteLine("maximum string value is " +strvalue);
                    break;


                    Console.ReadLine();
            }
        }
    }
}
