﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TesteSelecao1_1035
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);
            int C = int.Parse(valores[2]);
            int D = int.Parse(valores[3]);

            if (B > C && D > A && (C + D) > (A + B) && C > 0 && D > 0 && A % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            } else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}
