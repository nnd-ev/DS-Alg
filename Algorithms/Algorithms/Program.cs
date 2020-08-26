using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms {
    class Program {
        static void Main(string[] args) {
            //bubble sort

            int[] niz = { 3, 9, 1, 12, 99, 3, 28, 44, 1 };

            Console.WriteLine("Original array: ");
            for(int i=0;i<niz.Length; i++) {
                Console.Write(niz[i] + ", ");
            }

            for(int i=0; i<niz.Length-1; i++) {
                for(int j=i+1; j<niz.Length; j++) {
                    if(niz[i] > niz[j]) { 
                    int temp = niz[i];
                    niz[i] = niz[j];
                    niz[j] = temp;
                }
                }
            }

            Console.WriteLine("\nSorted array: ");

            foreach (int item in niz) {
                Console.Write(item + ", ");
            }

        }
    }
}
