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
            for (int n = 0; n < integerStrings.Length; n++)
            {
                integers[n] = int.Parse(integerStrings[n]);

                if(integers[n]%10 == 0)
                {
                    Console.WriteLine(integers[n] + " Es factor de 10");
                } 
            }
                

            
        }
    }
}
