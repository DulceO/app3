using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace app3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter ar;

            ar = File.AppendText("archivo.txt");

            String agenda = " ";
            Console.Write("Ingrese Nombre: ");
            agenda = Console.ReadLine() + "*";
            Console.Write("Ingrese Apellido: ");
            agenda = agenda + Console.ReadLine() + "*";

            Console.Write("Ingrese Telefono: ");
            agenda = agenda + Console.ReadLine() + "*";
            Console.Write("Ingresa Direccion: ");
            agenda = agenda + Console.ReadLine() + "*";
            ar.WriteLine(agenda);
            agenda = " ";
            Console.WriteLine("Buscar Contacto: ");
            string buscar = Console.ReadLine();
            ar.Close();

            StreamReader 1;
            1 = File.OpenText("archivo.txt");

            string linea;
            linea = 1.ReadLine();
            
        }
        }
    }

