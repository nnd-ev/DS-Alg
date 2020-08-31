using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms {
    class Program {
 
        static void Main(string[] args) {

            
            int[] niz = { 1,5, 3, 2, 1 };

            int[] novi_niz = new int[2];
            List<int> lista = new List<int>();

            int target = 8;
            for(int i=0; i<niz.Length; i++) {
                for(int j=i+1; i<niz.Length; i++) {
                    if(niz[j] == target - niz[i]) {
                        novi_niz[0] = j;
                        novi_niz[1] = i;

                        //lista.Add(i);
                        //lista.Add(j);
                    }
                }
            }

            foreach(int item in niz) {
                Console.WriteLine(item);
            }
            //Console.WriteLine("Vrati indexe: ");
            //foreach (var item in lista) {
            //    Console.WriteLine(item);
            //}

            Console.WriteLine("Vrati indexe: ");
            foreach (int item in novi_niz) {
                Console.WriteLine(item);
            }



             

            Console.ReadKey();
        }
    }
}
