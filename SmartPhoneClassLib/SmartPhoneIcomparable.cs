using System;


namespace SmartPhoneClassLib
{
    public class SmartPhoneIcomparable : SmartPhone,IComparable
    {
        public int CompareTo(object obj)
        {
           if(obj==null) return 1;
           SmartPhoneIcomparable s1 = obj as SmartPhoneIcomparable;
            if (s1 != null)
            {
                return this.Name.CompareTo(s1.Name);
            }
            else
            {
                Console.WriteLine("Phone Doesnt have a name");
                return -1;
            }
        }
    }
}
