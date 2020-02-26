using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{ 
    class Program
    {
        static string Address;
        public delegate int operation(int x, int y);
        static void Main(string[] args)
        {
            
            #region Conditional
            /*
            for (int i = 0; i < args.Length; i++)
            {
                if(args[i] == "Friday")
                {
                    if (3 < 5)
                    {
                        Console.WriteLine("5 is less than");
                    }
                    Console.WriteLine("we will work until 12am");
                }
                else if(args[i] == "Saturday")
                {
                    Console.WriteLine("Sleep all day");
                }
                else
                {
                    Console.WriteLine("No work");
                }
                switch (args[i])
                {
                    case "Friday":
                        Console.WriteLine("We will work until 12am");
                        break;
                    case "Saturday":
                        Console.WriteLine("Sleep all day");
                        break;
                    default:
                        Console.WriteLine("No Work");
                        break;
                }
                int x = 0;
                while (args[i] != "Friday" && x == 0)
                {
                    
                    Console.WriteLine("Today is not a friday");
                    x++;
                }
                //do
                //{
                //    Console.WriteLine("Do first");
                //}
                //while (args[i] != "Friday");
                Console.WriteLine("arg:" + i + ",value:" + args[i]);
            }
            */
            #endregion

            #region Variable & Datatypes
            Console.WriteLine("Hello World! - Today is friday");

            string dayoftheweek = "Friday";
            Console.WriteLine("Today is " + dayoftheweek);

            int dayofmonth = 31;
            Console.WriteLine("Day of the Month:" + dayofmonth);

            double amount = 10.5;
            Console.WriteLine("Amount:" + amount);

            bool valid;
            valid = true;
            Console.WriteLine("Is is Valid:" + valid);

            Address = "Test";
            Console.WriteLine("My address:" + Address);

            object sessions = "Dot Net Session";
            string newsession = (string)sessions;
            int a = 5; 
            int b = 4; 
            int sum = Calculation.CalculateSum(a, b);
            Console.WriteLine("a+b=" + sum);
            #endregion

            #region Collection
            LearnCollection learnCollection = new LearnCollection("Python");
            learnCollection.LearnStringList();

            //learnCollection.Langauge = "Python";

            learnCollection.LearnDoubleArray();
            learnCollection.LearnStringArray();
            learnCollection.LearnStringList();
           

            foreach (string language in learnCollection.Langauages)
            {
                Console.WriteLine(language);
            }
            #endregion


            #region Extension

            Trainer trainer = new Trainer("Mithun");

            trainer.ShowDepartment();

            string mfn = trainer.IsPersonMaleOfFemale();

            Student student = new Student();
            student.IsPersonMaleOfFemale();

            SWeekOfDay sWeek = new SWeekOfDay();
            sWeek.Days = "Monday";
            sWeek.DValue = 1;

            int x = 5;

            bool result = x.IsGreaterThan(6);

            #endregion

            #region System IO
            //SystemIO systemIO = new SystemIO();
            //systemIO.WriteToFile();
            //systemIO.WriteMultipleLineToFile(learnCollection.Langauages);
            //systemIO.ReadFileFromDirectory();
            //var path = systemIO.WriteToFile();
            //systemIO.ReadFile(path);
            #endregion

            #region Serialization & De

            SerializeDeserialize serializeDeserialize = new SerializeDeserialize();
            string json = serializeDeserialize.Serialization(learnCollection.Langauages);

            List<string> languages = serializeDeserialize.DeSerialization<List<string>>(json);


            List<Person> people = new List<Person>();
            people.Add(new Person() { FirstName = "Mithun", PhoneNumber="1234" });
            people.Add(new Person() { FirstName = "Adil", PhoneNumber = "2345" });
            people.Add(new Person() { FirstName = "Minhaz", PhoneNumber = "3456" });

            string pjson = serializeDeserialize.Serialization(people);

            List<Person> dpeople = serializeDeserialize.DeSerialization<List<Person>>(pjson);

            #endregion

            #region Delegates
            DelegatesEx delegatesEx = new DelegatesEx();
            // Delegate instantiation  
            operation obj = new operation(delegatesEx.Addition);
            int i = obj(5, 6);
            Console.WriteLine(i);
            #endregion

            #region Refelction
            
            System.Type type = learnCollection.GetType();
            System.Console.WriteLine(type);

            #endregion

            #region Tuples

            TupleEx tuple = new TupleEx();
            Tuple<string, int> t= tuple.GetTuple();
            Console.WriteLine("Name:" + t.Item1);
            Console.WriteLine("Id:" + t.Item2);
                
            #endregion

            Console.ReadLine();

        }

        //"Access Modifier" "Return Type" "Name of Method" (arguments)
        public static string[] LearnArrays()
        {
            //Datatype object
            string[] langauges = new string[5];
            langauges[0] = "C#";
            langauges[1] = "ASP.NET";
            langauges[2] = "SQL";
            langauges[3] = "Java";
            langauges[4] = "C++";

            return langauges;
        }
    }
}
