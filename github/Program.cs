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


        static void Main(string[] args)
        {
        }
    }
}
