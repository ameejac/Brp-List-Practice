using System;
using System.Collections.Generic;
using System.Text;

namespace ListCodePractice
{
    class Listcode
    {
        public void AddElements()
        {
            List<int> ItemList = new List<int>();
            ItemList.Add(10);
            ItemList.Add(20);
            ItemList.Add(30);
            ItemList.Add(40);
            ItemList.Add(50);
            ItemList.Add(60);
            Console.WriteLine(ItemList.Count);
            foreach (int items in ItemList)
            {
                Console.WriteLine("add elements in list:" + items);
            }
            int[] num = { 1, 2, 3, 4, 5 };
            List<int> numList = new List<int>();
            numList.AddRange(num);
            foreach (int items in numList)
            {
                Console.WriteLine("add elements in list:" + items);
            }

            ItemList.Remove(20);
            Console.WriteLine("num" + numList.Count);

            Console.WriteLine("after removing list size is :" + ItemList.Count);
            ItemList.RemoveAt(0);
            foreach (int items in ItemList)
            {
                Console.WriteLine("remaining items in a list:" + items);
            }

            ItemList.RemoveRange(0, 2);
            Console.WriteLine(ItemList.Count);
            foreach (int items in ItemList)
            {
                Console.WriteLine("remaining items in a list:" + items);
            }
            ItemList.Clear();
            Console.WriteLine(ItemList.Count);
        }
        public void sortmethod()
        {
            List<int> list = new List<int>();
            list.Add(30);
            list.Add(50);
            list.Add(10);
            list.Add(40);
            list.Add(20);
            list.Add(60);

            list.Sort();
            Console.WriteLine("list size:" + list.Count);
            foreach (int items in list)
            {
                Console.WriteLine(items);
            }
            list.Reverse();
            foreach (int items in list)
            {
                Console.WriteLine("after reversing the list:" + items);
            }
        }
    }
}
