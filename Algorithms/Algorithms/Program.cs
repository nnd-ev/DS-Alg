using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms {
    class Program {

        private static int binarySearch(int[] niz, int beg, int end, int numb) {
            int mid;
            if(end >= beg) {
                mid = (beg + end) / 2;
                if(niz[mid] == numb) {
                    return mid + 1;
                }else if(niz[mid] < numb) {
                    return binarySearch(niz, mid + 1, end, numb);
                } else {
                    return binarySearch(niz, beg, mid - 1, numb);
                }
            } 
            return -1;
        }
        
    
        static void Main(string[] args) {
            //binary search

            int[] niz = { 1,2,3,8,10,14,18};
            Console.WriteLine("Enter the number which you want to be searched");
            int number = int.Parse(Console.ReadLine());

            int location = -1;
            location = binarySearch(niz, 0, niz.Length, number);

            if(location != -1) {
                Console.WriteLine("Item found at location: " + location);
            } else {
                Console.WriteLine("Item not found");
            }



        }
    }
}
