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
            List<string> BancodePalabras = File.ReadLines(@"D:\TareaGit1\Numeros.txt").ToList();
        }
    }
}
