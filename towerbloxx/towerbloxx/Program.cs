using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace towerbloxx
{
    class Tabulka
    {
        
        int[,] tabulka;

        public void doplnovani(int n, int k)
        {
            tabulka = new int[n, k];

            for (int i = 0; i <= k; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    
                    if (k == 1)
                    {
                        tabulka[n,k] = n;
                    }
                    else
                    {
                        velkaMatematika(n,k);
                    }
                }
            }
        }

        public int velkaMatematika(int n, int k)
        {
            int[] maxiky = new int[n];

            for (int i = 0; i <= n; i++)
            {
                maxiky[i] = Math.Max(tabulka[n-i,k], tabulka[i,k-1]);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
