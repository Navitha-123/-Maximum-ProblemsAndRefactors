using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximiumNumbersAndRefactors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose option 1.IntergerMaxNumb \t 2.FloatMaxNum \t 3.Stringmax \t 4.Generic max value ");
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

                case 4:
                    GenericRefactor3To1Maximum genericRefactor3To1Maximum = new GenericRefactor3To1Maximum();
                    int val1 = genericRefactor3To1Maximum.PrintMaximumValue(908, 564, 7000);
                    float val2 = genericRefactor3To1Maximum.PrintMaximumValue(56.4f, 8.23f, 67.4f);
                    string val3 = genericRefactor3To1Maximum.PrintMaximumValue("banana", "watermellon", "papaya");
                    break;
                default:
                    Console.WriteLine("Enter wrong choice");
                    break;
                        Console.ReadLine();
            }
        }
    }
}
