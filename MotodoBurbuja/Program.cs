using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotodoBurbuja
{
    class Program
    {     
        private int[] OrdenarBurbuja(int[] n)
        {
            bool Ordenado;
            int temp, t, i;
            t = n.Length;
            Ordenado = false;
            i = 0;
            while (!Ordenado)
            {
                Ordenado = true;                
                {
                    for (int j = t - 1; j > i; j--)
                    {
                        if (n[j] < n[j - 1])
                        {
                            temp = n[j];
                            n[j] = n[j - 1];
                            n[j - 1] = temp;
                            Ordenado = false;
                        }
                    }
                }
                i++;
            }
            return n;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            int[] n = { 5, 4, 1, 3, 2 };
            int[] a = obj.OrdenarBurbuja(n);
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadKey();
        }
    }
}
