using SmartPhoneClassLib;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Xml.Linq;


namespace IcomparableIcomparableLinkedListDictSortedSet
{
    public class SortedSetDemo
    {
        static void Main(string[] args)
        { 
            SortedSet<string> Smartphones = new SortedSet<string>();
            Smartphones.Add("Iphones");
            Smartphones.Add("Redmi");
            Smartphones.Add("POCO");
            Smartphones.Add("Asus");
            Smartphones.Add("Sony");
            Smartphones.Add("Infinix");
            Smartphones.Add("BlackBerry");
            foreach (var item in Smartphones)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            SortedSet<SmartPhoneIcomparable> smList = new SortedSet<SmartPhoneIcomparable>();
            smList.Add(new SmartPhoneIcomparable() { IMEI = 49499499494494, Name = "Iphone", Model = "15 Pro Max", Price = 100000 });
            smList.Add(new SmartPhoneIcomparable() { IMEI = 33333333333332, Name = "Redmi", Model = "Note 9 Pro ", Price = 18000 });
            smList.Add(new SmartPhoneIcomparable() { IMEI = 56535653652145, Name = "Realme", Model = "9 Pro ", Price = 25000 });
            smList.Add(new SmartPhoneIcomparable() { IMEI = 12121212121210, Name = "Samsung", Model = "22 Ultra", Price = 120000 });
            smList.Add(new SmartPhoneIcomparable() { IMEI = 12121212121210, Name = "Asus", Model = "Rog 5", Price = 57000 });
            smList.Add(new SmartPhoneIcomparable() { IMEI = 12121212121210, Name = "Black Berry", Model = "6 max", Price = 30000 });
            smList.Add(new SmartPhoneIcomparable() { IMEI = 59864683468658, Name = "Nokia", Model = "6.1 pro", Price = 22000 });
            
            foreach (var item in smList)
            {
                Console.WriteLine(item.IMEI);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Model);
                Console.WriteLine(item.Price);
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
