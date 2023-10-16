using SmartPhoneClassLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcomparableIcomparerLinkedListDictSortedSet
{
    internal class DictionaryDemo
    {
        static void Main(string[] args)
        {



            Dictionary<int, String> num = new Dictionary<int, String>();
            num.Add(1, "Vika");
            num.Add(2, "RAM");
            num.Add(3, "Aadhya");
            Dictionary<int, String> num1 = new Dictionary<int, String>();
            num1.Add(3, "Vick");
            num1.Add(2, "RAM");
            num1.Add(1, "Vika");


            Console.WriteLine("Concating 2 Dictionary");
            IEnumerable<KeyValuePair<int, string>> DicConat1 = num1.Concat(num);
            foreach (var item in DicConat1)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }

            Console.WriteLine("Intersecting 2 Dictionary");
            IEnumerable<KeyValuePair<int, string>> DicIntersect1 = num.Intersect(num1);
            foreach (KeyValuePair<int, string> item in DicIntersect1)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }



            Dictionary < int,SmartPhone > smDic1= new Dictionary<int, SmartPhone> ();
            smDic1.Add(0, new SmartPhone() { IMEI = 49499499494494, Name = "Iphone", Model = "15 Pro Max", Price = 100000 });
            smDic1.Add(1, new SmartPhone() { IMEI = 33333333333332, Name = "Redmi", Model = "Note 9 Pro ", Price = 18000 });
            smDic1.Add(2, new SmartPhone() { IMEI = 12121212121210, Name = "Samsung", Model = "22 Ultra", Price = 120000 });

            Dictionary<int, SmartPhone> smDic2 = new Dictionary<int, SmartPhone>();
            smDic2.Add(0, new SmartPhone() { IMEI = 49499499494494, Name = "Iphone", Model = "15 Pro Max", Price = 100000 });
            smDic2.Add(5, new SmartPhone() { IMEI = 33333333333332, Name = "Redmi", Model = "Note 9 Pro ", Price = 18000 });
            smDic2.Add(6, new SmartPhone() { IMEI = 12121212121210, Name = "Asus", Model = "Rog 5", Price = 57000 });



            Console.WriteLine("Concating 2 Dictionary");
            IEnumerable<KeyValuePair<int, SmartPhone>> DicConat = smDic1.Concat(smDic2);
            foreach (var item in DicConat)
            {
                Console.WriteLine(item.Key + " : " + item.Value.Name);
            }
         
            Console.WriteLine("Intersecting 2 Dictionary");
            IEnumerable<KeyValuePair<int, SmartPhone>> DicIntersect = smDic1.Intersect(smDic2);
            //if (DicIntersect == null)
            //{
                foreach (KeyValuePair<int, SmartPhone> item in DicIntersect)
                {
                    Console.WriteLine(item.Key + " : " + item.Value);
                }
           // }
            //else
            //{
              //  Console.WriteLine("No Matching Found");
            //}
       
            Console.ReadLine();

        }
    }
}
