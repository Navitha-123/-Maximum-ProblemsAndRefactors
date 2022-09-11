using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximiumNumbersAndRefactors
{
    public class StringsMaximum
    {
        public String PrintMaximumString(String str1, String str2, String str3) 
        {
            if (str1.CompareTo(str2) > 0 && str1.CompareTo(str3) < 0
                || str1.CompareTo(str2) >= 0 && str1.CompareTo(str3) > 0
                || str1.CompareTo(str2) > 0 && str1.CompareTo(str3) >= 0)
            {
                return str1;
            }
            if (str2.CompareTo(str1) > 0 && str2.CompareTo(str3) > 0
               || str2.CompareTo(str1) >= 0 && str2.CompareTo(str3) > 0
               || str2.CompareTo(str1) > 0 && str2.CompareTo(str3) >= 0)
            {
                return str2;
            }
            if (str3.CompareTo(str1) > 0 && str3.CompareTo(str2) > 0
               || str3.CompareTo(str1) >= 0 && str3.CompareTo(str2) > 0
               || str3.CompareTo(str1) > 0 && str3.CompareTo(str2) >= 0)
            {
                return str3;
            }
            return str1;
        }
    }
}
