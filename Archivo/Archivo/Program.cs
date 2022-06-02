/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos
{
    internal class Program
    {
        class Alumno
        {
            
        }
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
}*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GarciaCortez_Unidad2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lineas = new string[100];
            
           
            

                
                

             
            
            //Campos
            string nombreCliente, direccion, marcaAuto;
            Int64 telefono;
            int añoAuto;

            //Captura
            Console.WriteLine("\t Taller ITT \t");
            Console.Write("\nIngresa Nombre del Cliente: ");
            nombreCliente = Console.ReadLine();
            Console.Write("\nIngresa Dirección: ");
            direccion = Console.ReadLine();
            Console.Write("\nIngresa Teléfono: ");
            telefono = Int64.Parse(Console.ReadLine());
            Console.Write("\nIngresa Marca del Automóvil: ");
            marcaAuto = Console.ReadLine();
            Console.Write("\nIngresa Año del Automóvil: ");
            añoAuto = int.Parse(Console.ReadLine());

            //Objeto
            TallerITT cliente1 = new TallerITT(nombreCliente, direccion, telefono, marcaAuto, añoAuto);
            Console.Clear();
            //Campos Auxiliares
            float diagnostico, costom, costoR;
            Console.Write("\nIngresa Costo del diagnostico: ");
            diagnostico = float.Parse(Console.ReadLine());
            Console.Write("\nIngresa Costo de mano de obra: ");
            costom = float.Parse(Console.ReadLine());
            Console.Write("\nIngresa Costo de las refacciones: ");
            costoR = float.Parse(Console.ReadLine());

            //Ejecucion Precio por diagnostico
            cliente1.DesplegarCosto(cliente1.CalcularCosto(diagnostico));
            Console.WriteLine("\nDar ENTER para siguiente ejecucuion: ");
            Console.ReadKey();
            Console.Clear();
            //Ejecucion Precio por diagnostico + mano de obra
            cliente1.DesplegarCosto(cliente1.CalcularCosto(diagnostico, costom));
            Console.WriteLine("\nDar ENTER para siguiente ejecucuion: ");
            Console.ReadKey();
            Console.Clear();
            //Ejecucion Precio por diagnostico + mano de obra+ refacciones
            cliente1.DesplegarCosto(cliente1.CalcularCosto(diagnostico, costom, costoR));
            Console.WriteLine("\nDar ENTER para salir ");
            Console.ReadKey();

            
        }
    }
    //Clase
    class TallerITT
    {
        //Campos
        string nombreCliente, direccion, marcaAuto;
        Int64 telefono;
        int añoAuto;
        //Constructor
        public TallerITT(string nombreCliente, string direccion, Int64 telefono, string marcaAuto, int añoAuto)
        {
            this.nombreCliente = nombreCliente;
            this.direccion = direccion;
            this.telefono = telefono;
            this.marcaAuto = marcaAuto;
            this.añoAuto = añoAuto;
        }
        //Metodos
        public double CalcularCosto(float Diagnostico)
        {
            return Diagnostico * 1.15;
        }
        public double CalcularCosto(float Diagnostico, float ManoO)
        {
            return (Diagnostico + ManoO) * 1.15;
        }
        public double CalcularCosto(float Diagnostico, float ManoO, float Refacciones)
        {
            return (Diagnostico + ManoO + Refacciones) * 1.15;
        }
        //Despliegue
        public void DesplegarCosto(double costo)
        {
            StreamWriter sw = new StreamWriter("ejemplo.txt", true);
            string[] lineas = new string[100];
            Console.WriteLine("Nombre del Cliente: " + nombreCliente);
            lineas[0] = nombreCliente;
            Console.WriteLine("Dirección: " + direccion);
            lineas[1]= direccion;
            Console.WriteLine("Teléfono: " + telefono);
            lineas[2] = telefono.ToString();
            Console.WriteLine("Marca del Automóvil: " + marcaAuto);
            lineas[3] = marcaAuto;
            Console.WriteLine("Año del Automóvil: " + añoAuto);
            lineas[4] = añoAuto.ToString() ;
            Console.WriteLine("Costo: $", costo);
            lineas[5] = costo.ToString();
            foreach (string line in lineas)
            {
                sw.WriteLine(line);
            }
            sw.Close();
        }
        //Destructor
        ~TallerITT()
        {
            Console.WriteLine("Memoria Objeto Taller Liberada" + this.nombreCliente);
        }
    }
}