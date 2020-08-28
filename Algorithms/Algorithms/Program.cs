using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms {
    class Program {

       
        
        

        static void Main(string[] args) {
            //Binary search-while way

            int[] niz = { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            //int[] niz = {1,2,3,4,5,6,7,8};

            Console.WriteLine("Original array: ");
            foreach (int item in niz) {
                Console.Write(item + " ");
            }

            int i, max, min;
            max = niz[0];
            min = niz[0];

            for(i=0; i<niz.Length; i++) {
                if(niz[i] > max) {
                    max = niz[i];
                }
                if(niz[i]< min) { 
                    min = niz[i];
                }
            }
            Console.WriteLine("Max elemente in array is -> "+ max);
            Console.WriteLine("Min elemente in array is -> "+ min);

            //    Console.WriteLine("Soreted array: ");
            //foreach (int item in niz) {
            //    Console.Write(item + " ");
            //} 
        }
    }
}
