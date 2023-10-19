using System;
using System.Collections.Generic;


namespace SmartPhoneClassLib
{
    public class SmartPhoneIcomparer :SmartPhone, IComparer<SmartPhoneIcomparer>
    {
        public int Compare(SmartPhoneIcomparer x, SmartPhoneIcomparer y)
        {
           SmartPhoneIcomparer s1= x as SmartPhoneIcomparer;
           SmartPhoneIcomparer s2 = y as SmartPhoneIcomparer;
           return s1.Name.CompareTo(s2.Name);
        }
    }
}
