using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LessonOne.SelfPractise
{
    internal class CollectionPractise
    {
        public static void ListCollection()
        {
            var boxes = new List<string>();
            List<string> names = new List<string>();
            boxes.Add("regular");
            boxes.Add("helloa");
            boxes.Add("hellob");
            boxes.Sort();
            foreach (var box in boxes)
            {
                Console.WriteLine(box);
            }

        }


        //ARRAYLIST
        public static void ArrList()//
        {
            ArrayList arrayLista = new ArrayList();
            arrayLista.Add("No Fixed");
            arrayLista.Add(2);
            arrayLista.Add("dataType in arraylist");
            arrayLista.Add(2);
            int[] num = { 1, 2, 3, 4, 5 };

            arrayLista.Add(num);
            foreach (var item in arrayLista)
            {
                Console.WriteLine(item);
            }

            int[] retrivedArray = (int[])arrayLista[4];//retriving the array stored in the arraylist
            foreach(int i in retrivedArray)
            {
                Console.WriteLine(i);
            }
        }

        //DICTIONARY
        public static void Dict1()
        {

            Dictionary<int, String> dict1 = new Dictionary<int, String>();
            dict1.Add(1, "Abbb");
            dict1.Add(2, "B");
            dict1.Add(3, "C");
            dict1.Add(4, "D");

            string access = dict1[1];
            Console.WriteLine($"Access: {access}");
        }

        public static void SetPrac()
        {
            SortedSet<int> Set1 = new SortedSet<int>();
            Set1.Add(1111);
            Set1.Add(001);
            Set1.Add(5);    
            Set1.Add(5);

            foreach (var item in Set1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
         

