using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public static class IntExtension
    {
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }
    }

    public static class PersonExtension
    {
        public static string IsPersonMaleOfFemale(this Person p)
        {
            if(p.Gender== "Male")
            {
                return "M";
            }
            else if(p.Gender == "Female")
            {
                return "F";
            }
            else
            {
                return "N";
            }
        }
    }
}
