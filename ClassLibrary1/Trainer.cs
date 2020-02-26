using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Trainer : Person, IDepartment
    {
        public double Salary { get; set; }
        public int DepartmentId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string DepartmentName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        // Constructor Inheritance
        public Trainer(string name)  : base(name)
        {
            Console.WriteLine(name);
            
        }

        public void FindDepartment()
        {
            throw new NotImplementedException();
        }

        public void RegisterDepart()
        {
            throw new NotImplementedException();
        }

        public override void ShowDepartment()
        {
            Console.WriteLine("We are in ShowDepartment method inside child class");
            base.ShowDepartment();
        }
    }
}
