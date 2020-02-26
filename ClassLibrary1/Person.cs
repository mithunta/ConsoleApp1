using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public  class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }

        public Person()
        {

        }
        public Person(string name)
        {
            Console.WriteLine("Base class contructor");
        }

        public virtual void ShowDepartment()
        {
            Console.WriteLine("Base class ShowDepartment");
        }

        public void ShowCourses()
        {
            Console.WriteLine("Base class Show Courses");
        }
        
    }

    public interface IDepartment
    {
        int DepartmentId { get; set; }
        string DepartmentName { get; set; }

        void FindDepartment();

        void RegisterDepart();
    }

    
}
