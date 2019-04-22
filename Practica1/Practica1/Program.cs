using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Numeros = File.ReadAllText(@"D:\TareaGit1\Numeros.txt").ToString();
            string[] integerStrings = Numeros.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int[] integers = new int[integerStrings.Length];
            for (int i = 0; i < integerStrings.Length; i++)
            {
                integers[i] = int.Parse(integerStrings[i]);

                if(integers[i]%10 == 0)
                {
                    Console.WriteLine(integers[i] + " Es multiplo de 10");
                } 
            }
                

            
        }
    }
}
