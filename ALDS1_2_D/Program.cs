using System;
using System.Linq;
using System.Collections.Generic;

namespace ALDS1_2_D
{
    public static class Program
    {
        public static int cnt = 0;
        public static int m = 0;
        public static List<int> G = new List<int>();

        
        public static void InsertionSort(int[] A, int n, int g)
        {

            for (int i = g; i < n; i++)
            {
                int v = A[i];
                int j = i - g;

                while (j >= 0 && A[j] > v)
                {
                    A[j + g] = A[j];
                    j -= g;
                    cnt++;
                }
                A[j + g] = v;
            }
        }

        public static void ShellSort(int[] A, int n)
        {
            G.Add(1);
            int count = 1;
            while (G[count - 1] < n)
            {
                G.Add(3 * G[count - 1] + 1);    
                count++;
            }
            if(n != 1)
            {
                G.RemoveAt(count - 1);
            }

            G.Reverse();
            for(int i = 0; i < G.Count(); i++)
            {
                InsertionSort(A, n, G[i]);
            }
            
            
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var A = new int[n];
            for(int i = 0; i < n; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            ShellSort(A, n);
            
            for(int i = 0; i < n; i++)
            {
                if(i == 0)
                {
                    Console.WriteLine(G.Count());
                    Console.WriteLine(string.Join(' ', G));
                    Console.WriteLine(cnt);
                }
                Console.WriteLine(A[i]);

            }  
        }
    }
}
