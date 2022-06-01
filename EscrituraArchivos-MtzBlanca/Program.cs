using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EscrituraArchivos_MtzBlanca
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("Ejemplo.txt", true);

            string[] lines = {
                "\nesto es una nueva linea" +
                "\nsgunda linea" +
                "\ntecera linea"
            };

            foreach(string line in lines) {
                sw.WriteLine(line);
                    }

            sw.Close();
            Console.WriteLine("escribiendo");
            Console.ReadLine();

        }
    }
}
