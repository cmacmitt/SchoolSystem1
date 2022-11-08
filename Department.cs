using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem1
{
    internal class Department
    {
        public string Name { get; set; }
        public HashSet<Diploma> Diplomas { get; private set; }

        public Department(string name)
        {
            Name = name;
            Diplomas = new HashSet<Diploma>();
        }

        public void AddDiploma(Diploma diploma)
        {
            Diplomas.Add(diploma);
        }
    }
}
