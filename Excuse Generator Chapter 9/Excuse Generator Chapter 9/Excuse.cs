using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Excuse_Generator_Chapter_9
{
    [Serializable]
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
            string[] fileNames = Directory.GetFiles(selectedFolder, "*.excuse");
            OpenFile(fileNames[random.Next(fileNames.Length)]);
        }

        public void OpenFile(string fileName)
        {
            this.ExcusePath = fileName;
            using (Stream input = File.OpenRead(fileName))
            {
                BinaryFormatter bf = new BinaryFormatter();
                Excuse excuse = (Excuse)bf.Deserialize(input);
                Description = excuse.Description;
                Results = excuse.Results;
                LastUsed = Convert.ToDateTime(excuse.LastUsed);
            }
        }
        
        public void Save(string fileName)
        {
            this.ExcusePath = fileName;
            using (Stream stream = File.Create(fileName))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(stream, this);
            }            
        }

    }
}
