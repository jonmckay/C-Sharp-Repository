using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excuse_Generator_Chapter_9
{
    class Excuse
    {
        public string Description { get; set; }
        public string Results { get; set; }
        public DateTime LastUsed { get; set; }
        public string ExcusePath { get; set; }
        
        public Excuse()
        {
            ExcusePath = "";
        }

        public Excuse(string excusePath)
        {
            OpenFile(excusePath);
        }

        public Excuse(Random random, string selectedFolder)
        {
            string[] fileNames = Directory.GetFiles(selectedFolder, "*.txt");
            OpenFile(fileNames[random.Next(fileNames.Length)]);
        }

        public void OpenFile(string fileName)
        {
            this.ExcusePath = fileName;
            using (StreamReader sr = new StreamReader(fileName))
            {
                this.Description = sr.ReadLine();
                this.Results = sr.ReadLine();
                this.LastUsed = Convert.ToDateTime(sr.ReadLine());
            }
        }

        public void Save(string fileName)
        {
            this.ExcusePath = fileName;
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.WriteLine(Description);
                sw.WriteLine(Results);
                sw.WriteLine(LastUsed);
            }
        }

    }
}
