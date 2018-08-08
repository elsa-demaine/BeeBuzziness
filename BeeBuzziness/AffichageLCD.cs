using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeBuzziness
{
    public class AffichageLCD
    {
        public void Print(string nb)
        {
            List<string> top = new List<string>();
            List<string> middle = new List<string>();
            List<string> bottom = new List<string>();

            foreach (char c in nb)
            {
                if (c == '0')
                {
                    top.Add(" _ ");
                    middle.Add("| |");
                    bottom.Add("|_|");
                }
                else if (c == '1')
                {
                    top.Add("   ");
                    middle.Add("  |");
                    bottom.Add("  |");
                }
                else if (c == '2')
                {
                    top.Add(" _ ");
                    middle.Add(" _|");
                    bottom.Add("|_ ");
                }
                else if (c == '3')
                {
                    top.Add(" _ ");
                    middle.Add(" _|");
                    bottom.Add(" _|");
                }
                else if (c == '4')
                {
                    top.Add("   ");
                    middle.Add("|_|");
                    bottom.Add("  |");
                }
                else if (c == '5')
                {
                    top.Add(" _ ");
                    middle.Add("|_ ");
                    bottom.Add(" _|");
                }
                else if (c == '6')
                {
                    top.Add(" _ ");
                    middle.Add("|_ ");
                    bottom.Add("|_|");
                }
                else if (c == '7')
                {
                    top.Add(" _ ");
                    middle.Add("  |");
                    bottom.Add("  |");
                }
                else if (c == '8')
                {
                    top.Add(" _ ");
                    middle.Add("|_|");
                    bottom.Add("|_|");
                }
                else if (c == '9')
                {
                    top.Add(" _ ");
                    middle.Add("|_|");
                    bottom.Add(" _|");
                }
            }

            List<List<string>> lists = new List<List<string>>();
            lists.Add(top);
            lists.Add(middle);
            lists.Add(bottom);

            foreach (List<string> l in lists)
            {
                foreach (string s in l)
                {
                    Console.Write(s);
                }
                Console.WriteLine();
            }
        }
    }
}
