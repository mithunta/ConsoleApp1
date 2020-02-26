using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Student : Person, IDepartment
    {
        #region Constant
        private const int PiValue = 3;
        
        #endregion

        #region Variable
        private string name;
        #endregion

        #region Properties
        public int DepartmentId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string DepartmentName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        #endregion

        #region Constructor
        public Student()
        {
            Console.WriteLine("Student:" + name);
        }
        #endregion

        #region Methods
        public void FindDepartment()
        {
            throw new NotImplementedException();
        }

        public void RegisterDepart()
        {
            DepartmentId = 1;

        }

        public override void ShowDepartment()
        {
            Console.WriteLine("We are in ShowDepartment method inside child class");
        }

        #endregion
    }
}
