using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeBuzziness
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez saisir un nombre.");
            string nombre = Console.ReadLine();

            AffichageLCD lcd = new AffichageLCD();
            lcd.Print(nombre);

        }        
    }
}
