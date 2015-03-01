using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamWriter_Chapter_9
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\Jon\Desktop\GitHub Repo\C-Sharp-Repository\StreamWriter Chapter 9\secret_plan.txt");

            sw.WriteLine("How I'll defeat Captain Amazing");

            sw.WriteLine("Another genius secret plan by The Swindler");

            sw.Write("I'll create an army of clones and ");

            sw.WriteLine("unleash them upon the citizens of Objectville.");

            string location = "the mall";

            for (int number = 0; number <= 6; number++)
            {
                sw.WriteLine("Clone # {0} attacks {1}", number, location);
                if (location == "the mall")
                {
                    location = "downtown";
                }
                else
                {
                    location = "the mall";
                }
            }

            sw.Close();
        }
    }
}
