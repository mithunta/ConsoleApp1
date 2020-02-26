using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public enum WeekdOfDay : uint
    {
        
        Monday = 10,
        Tuesday = 2,
        Wedesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7
    }

    public struct SWeekOfDay
    {
        public string Days { get; set; }
        public int DValue { get; set; }
    }
}
