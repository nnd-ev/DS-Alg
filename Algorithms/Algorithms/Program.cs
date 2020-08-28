using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms {
    class Program {

       
        private static int binarySearch(int[] niz, int len, int number) {
            int first, last, mid;
            first = 0;
            last = len - 1;

            while(first <= last) {
                mid = (first + last) / 2;
                if (niz[mid] == number)
                    return mid;
                if (number < niz[mid])
                    last = mid + 1;
                else
                    first = mid + 1;
            }

            return -1;
        }
        
    
        static void Main(string[] args) {
            //Binary search-while way

            //int[] niz = { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            int[] niz = {1,2,3,4,5,6,7,8};

            Console.WriteLine("Original array: ");
            foreach (int item in niz) {
                Console.Write(item + " ");
            }

            Console.WriteLine("What number's index you wanna find? ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Position of searched element is at: "+ binarySearch(niz, niz.Length, number));
            


            //    Console.WriteLine("Soreted array: ");
            //foreach (int item in niz) {
            //    Console.Write(item + " ");
            //} 
        }
    }
}
