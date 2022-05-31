using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("ejemplo.txt",true);
            string[] lineas =
            {
                "Esta es la nueva escritura",
                "Fin txt"
            };
            foreach (string line in lineas)
            {
                sw.WriteLine(line);
            }
            sw.Close();
            Console.WriteLine("Escribiendo...");
            Console.ReadKey();
        }
    }
}