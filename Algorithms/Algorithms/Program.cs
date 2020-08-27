using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms {
    class Program {

       
        
    
        static void Main(string[] args) {
            //Shell sort

            int[] niz = { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            
            Console.WriteLine("Original array: ");
            foreach (int item in niz) {
                Console.Write(item + " ");
            }
            int len = niz.Length;
            int i, j, k, tmp;
            for (i = len / 2; i > 0; i = i / 2) {
                for (j = i; j < len; j++) {
                    for (k = j - i; k >= 0; k = k - i) {
                        if (niz[k + i] >= niz[k])
                            break;
                        else {
                            tmp = niz[k];
                            niz[k] = niz[k + i];
                            niz[k + i] = tmp;
                        }
                    }
                }
                }


                Console.WriteLine("Soreted array: ");
            foreach (int item in niz) {
                Console.Write(item + " ");
            } 
        }
    }
}
