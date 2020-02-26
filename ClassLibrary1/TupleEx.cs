using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class TupleEx
    {
        public Tuple<string, int> GetTuple()
        {
            string name = "Mithun";
            int id = 10;

            return Tuple.Create(name, id);
        }

        public object[] GetVs()
        {
            string name = "Mithun";
            int id = 10;
            return new object[] { name, id };
        }
    }
}
