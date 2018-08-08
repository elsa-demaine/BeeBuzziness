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
            AffichageLCD lcd = new AffichageLCD();
            bool exit = true;

            while (exit) { 
                Console.WriteLine("Veuillez saisir un nombre.");
                string nombre = Console.ReadLine();
                bool integer = int.TryParse(nombre, out int nb);
                if (integer)
                    lcd.Print(nombre);
                else
                    Console.WriteLine("Erreur. Veuillez saisir que des nombre. (ex : 0123)");
                Console.WriteLine("Voulliez vous quitter ? (o/n)");
                string quit = Console.ReadLine();
                if (quit == "o" || quit == "O")
                    exit = false;
                Console.Clear();
            }
        }        
    }
}
