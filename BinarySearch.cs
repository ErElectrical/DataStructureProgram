using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureDemo
{
    class BinarySearch
    {



        // FindWord Method that basically implements the Binary search.
        //Binary search works on a sorted array.
        //The value is compared with the middle element of the array.
        //If equality is not found, then the half part is eliminated in which the value is not there.
        //In the same way, the other half part is searched.


        public int FindWord(string[] words, string str)
        {
            int start = 0;
            int end = words.Length - 1;
            while (start <= end)
            {
                // initialize mid index
                int mid = start + end / 2;
                int result = str.CompareTo(words[mid]);
                // here what we try to do is that
                // we compare search str till mid index and store that result to 
                // varible result.
                if (result == 0)
                {
                    return mid;
                    // if result is 0 that means our target is at 0th index
                }
                if (result > 0)
                {
                    start = mid + 1;
                    // if result is more thn 0th index thn we simply increse the start
                    // and put it ahead of mid
                }
                else
                {
                    end = mid - 1;
                    // in else part we shorten our while loop 
                }
            }
            return -1;
        }
    }
}
