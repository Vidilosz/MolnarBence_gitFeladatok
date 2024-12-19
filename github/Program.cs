using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace github
{
    internal class Program
    {
        static void F01(int[] arr)
        {
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1,51);
            }
        }

        static int F02(int[] arr)
        {
            int szamlalo = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i]%2 == 0)
                {
                    szamlalo++;
                }
            }

            return szamlalo;
        }

        static double F03(int[] arr)
        {
            double atlag = 0.0;

            for (int i = 0;i < arr.Length;i++)
            {
                atlag += arr[i];
            }
            return atlag/arr.Length;

        }

        static int[] F04(int[] arr)
        {
            int[] paratlanok = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    paratlanok[i] = arr[i] + 1;
                }
                else
                {
                    paratlanok[i] = arr[i];
                }
            }

            return paratlanok;
        }


        static void F05(int[] arr)
        {
            Console.WriteLine($"Ennyi db pozitív szám van a tömbben: {F02(arr)}");

            Console.WriteLine($"A tömb elemeinek átlaga: {F03(arr):F4}");

            Console.WriteLine("A tömbből alkotott páratlan számok: ");

            foreach (var item in F04(arr))
            {
                Console.Write($"{item}, ");
            }

            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            int[] szamok = new int[10];
            F01(szamok);
            F05(szamok);
        }
    }
}
