using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureDemo
{
    class DataStructure
    {
        public void Anagrams(string str1,string str2)
        {
          
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string first = new string(ch1);
            string second = new string(ch2);
            if (first == second)
                Console.WriteLine("Strings are Anagrams");
            else
                Console.WriteLine("Strings are not Anagrams");
        }
    }
}