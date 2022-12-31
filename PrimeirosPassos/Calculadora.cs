using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    internal class Calculadora
    {
        public static int Sum (params int[] number)
        {
            int sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i];
            }
            return sum; 
        }
        public static void Triple ( ref int x)
        {
            x = x * 3;
        }

       
    }
}
