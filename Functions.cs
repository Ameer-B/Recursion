using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Recursion
{
    public class Functions<T> where T : IComparable
    {
        public void starTriangle(int x)
        {
            if (x > 4)
            {
                return;
            }
            for (int i = 0; i < x; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            starTriangle(x + 1);
        }


        public bool Contains(T[] items, T itemToFind)
        {
            return ContainsHelper(items, itemToFind, 0, items.Length - 1);
        }

        bool ContainsHelper(T[] items, T itemToFind, int left, int right)
        {
            if(left > right)
            {
                return false;
            }

            int middleIndex = (left + right) / 2;

            T currentItem = items[middleIndex];

            if (currentItem.CompareTo(itemToFind) == 0)
            {
                return true;
            }

            else if (itemToFind.CompareTo(items[middleIndex]) < 0)
            {
                //pass in a new right, keep the left the same
            }
            else
            {
             
            }

            ContainsHelper(items, itemToFind, currentItem, 0, items.Length-1);

            return false;
        }
    }
}