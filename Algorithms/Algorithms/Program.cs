using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms {
    class Program {

        
    
        static void Main(string[] args) {
            //sequental search

            int[] niz = { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };

            Console.WriteLine("Enter desired value: ");
            int n = int.Parse(Console.ReadLine());

            for(int i=0; i<niz.Length; i++) {
                 
                     if(niz[i] == n){
                    Console.WriteLine("it's location is on {0}", i+1);
                    return;
                }
               else if(i == niz.Length - 1) {
                    Console.WriteLine("There is not such element in array.");
                } 
                   
            }

        }
    }
}
