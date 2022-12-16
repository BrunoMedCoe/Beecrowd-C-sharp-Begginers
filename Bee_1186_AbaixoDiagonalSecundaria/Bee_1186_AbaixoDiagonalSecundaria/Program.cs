﻿using System;

namespace Bee_1186_AbaixoDiagonalSecundaria
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char O = char.Parse(Console.ReadLine());

            float[,] matrix = new float[12, 12];
            float soma = 0;

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    matrix[i, j] = float.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    if (j > 12 - i - 1)
                    {
                        soma += matrix[i, j];
                    }
                }
            }
            if (O == 'S')
            {
                Console.WriteLine($"{soma:f1}");
            }
            else if (O == 'M')
            {
                Console.WriteLine($"{soma / 66.0f:f1}");
            }
        }
    }
}