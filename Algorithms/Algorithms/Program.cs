using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms {
    class Program {

       
        
    
        static void Main(string[] args) {
            //Insertion sort

            int[] niz = { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            //Console.WriteLine("Enter the number which you want to be searched");
            //int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Original array: ");
            foreach (int item in niz) {
                Console.Write(item + " ");
            }


            for (int i=1; i<niz.Length; i++) {
                int temp = niz[i]; //tem=1
                int j= i - 1; //j=0

                while(j>=0 && temp <= niz[j]) {
                    niz[j + 1] = niz[j];
                    j = j - 1;
                }

                niz[j + 1] = temp;
            }

            Console.WriteLine("Soreted array: ");
            foreach(int item in niz) {
                Console.Write(item + " ");
            }
 



        }
    }
}
