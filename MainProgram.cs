﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data structure sorting Program");

            // Binarysearch ********************************

            //BinarySearch dataStructure = new BinarySearch();
            //string[] words = { "decs", "read", "logic", "search" };
            //string data = "search";
            //int result = dataStructure.FindWord(words, data);
            //if (result == -1)
            //    Console.WriteLine("Word not present");

            //else
            //    Console.WriteLine("Word is found at " + result);

            // InsertionSort **************************************

            //string[] names = { "One", "Two","Three", "Four", "Six","seven" };
            //InsertionSort dataStructure = new InsertionSort();
            //dataStructure.Insertion(names);

            BubbleSort sort = new BubbleSort();
            sort.Bubble();




        }
    }
}