using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDemo
{
    public class BubbleSort
    {
        public void Bubble()
        {
            int[] numbers = { 564, 75, 200, 778, 1487 };
            int temp;
            for (int i = 0; i <= numbers.Length - 2; i++)
            {
                for (int j = 0; j <= numbers.Length - 2; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        temp = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            foreach (int p in numbers)
                Console.Write($"{p}, ");
        }



    }

}
