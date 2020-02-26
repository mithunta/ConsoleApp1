using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ClassLibrary1
{
    public class SystemIO
    {
        const string basepath = @"C:\dev\Personal\RemoteTiger\Batch3\Files";
        public string WriteToFile()
        {
            
            string filename = DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
            string fullpath = Path.Combine(basepath, filename);
            File.WriteAllText(fullpath, DateTime.Now + ": DOT NET Training" + "\r\n");
            return fullpath;
        }

        public void ReadFile(string fullpath)
        {
            string data = File.ReadAllText(fullpath);
            Console.WriteLine(data);
        }

        public void WriteMultipleLineToFile(List<string> languages)
        {
            string filename = DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
            string fullpath = Path.Combine(basepath, filename);
            foreach(string l in languages)
            {
                File.AppendAllText(fullpath, DateTime.Now + ":" + l + "\r\n");
            }
        }
        public void ReadFileFromDirectory()
        {
            string[] files = Directory.GetFiles(basepath, "*.txt");
            foreach(string file in files)
            {
                Console.WriteLine("file:" + file);
                ReadLines(file);
            }
        }

        public void  ReadLines(string file)
        {
            string[] lines = File.ReadAllLines(file);
            foreach(string line in lines)
            {
                Console.WriteLine("file:" + line);
            }

        }
    }
}
