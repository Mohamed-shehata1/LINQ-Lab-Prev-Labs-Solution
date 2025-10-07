using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    internal class Department
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public override string ToString()
        {
            return $"{Number} - {Name} - {Capacity}";
        }
    }
}
