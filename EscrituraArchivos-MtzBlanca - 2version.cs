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
            try
            {
                //Open the File
                StreamWriter sw = new StreamWriter("Ejemplo2.txt", true, Encoding.ASCII);

                //Write out the numbers 1 to 10 on the same line.
                for (int x = 0; x < 10; x++)
                {
                    sw.Write(x);
                }

                //close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        
    }
}
