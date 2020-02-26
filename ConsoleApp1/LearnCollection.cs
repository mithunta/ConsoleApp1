using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class LearnCollection
    {
        private bool areweLearning;
        public string Langauge { get; private set; }
        public List<string> Langauages
        {
            get;  set;
        }
        public LearnCollection()
        {
            Console.WriteLine("Default Contructor");
        }
        public LearnCollection(string langauge)
        {
            Langauge = langauge;
        }
        ~LearnCollection()
        {

        }
        public string[] LearnStringArray()
        {
            string[] langauges = new string[6];
            langauges[0] = "C#";
            langauges[1] = "ASP.NET";
            langauges[2] = "SQL";
            langauges[3] = "Java";
            langauges[4] = "C++";
            langauges[5] = Langauge;
            return langauges;
        }

        public double[] LearnDoubleArray()
        {
            double[] numbers = new double[7];
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = new Random().NextDouble();
            }
            return numbers;
        }


        /// <summary>
        /// This method adds items to the list.
        /// </summary>
        public void LearnStringList()
        {
            Langauages = new List<string>();
            try
            {
                Langauages.Add("C#");
                Langauages.Add("ASP.NET");
                Langauages.Add("C");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Language method has finished executing");
            }
            
        }
        public void LearnDictionary()
        {
            Dictionary<int, string> langauges = new Dictionary<int, string>();
            langauges.Add(1, "C#");
            langauges.Add(2, "ASP.NET");
            langauges.Add(3, "SQL");
            
            foreach (KeyValuePair<int, string> langague in langauges)
            {
                Console.WriteLine("Key:" + langague.Key + ",Value:" + langague.Value);
            }

        }
        public void LearnHashTable()
        {
            Hashtable langauges = new Hashtable();
            langauges.Add(1, "C#");
            langauges.Add(2, "ASP.NET");
            langauges.Add(3, "SQL");
        }
    }
}
