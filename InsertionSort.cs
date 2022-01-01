using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDemo
{
    public class InsertionSort
    {

        //Insertion sort is a simple sorting algorithm that works similar to the way
        //you sort playing cards in your hands.
        //The array is virtually split into a sorted and an unsorted part.
        //Values from the unsorted part are picked and placed at the correct position in the sorted part.
        //Algorithm
        //To sort an array of size n in ascending order: 
        //1: Iterate from arr[1] to arr[n] over the array.
        //2: Compare the current element (key) to its predecessor. 
        // If the key element is smaller than its predecessor,
        // compare it to the elements before. Move the greater elements one position
        // up to make space for the swapped element.

        public void Insertion(IComparable[] names)
        {

            //IComparable Interface in C# to sort elements.
            //It is also used to compare the current instance with another object of same type.
            //It provides you with a method of comparing two objects of a particular type.
            //Remember, while implementing the IComparable interface,
            //CompareTo() method should also be implemented.
            int i, j;

            for (i = 1; i < names.Length; i++)
            {
                IComparable data = names[i];
                j = i - 1;
                while ((j >= 0) && (names[j].CompareTo(data) > 0))
                {
                    names[j + 1] = names[j];
                    j--;
                }
                names[j + 1] = data;
            }
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
