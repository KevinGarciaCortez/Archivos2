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
            string[] lineas = new string[5];
            int opc=0;
            StreamWriter sw = new StreamWriter("ejemplo.txt", true);
            do { 
               
            Console.WriteLine("Ingresa un nombre");
                lineas[opc] = Console.ReadLine();
            
                opc++;
        }while (opc!=5) ;
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