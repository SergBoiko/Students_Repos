using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_ClassLibrary
{
    public class Group
    {
        public List<Student> Students;

        public Group(string name, int number)
        {
            Students = new List<Student>(); 
            this.Name = name;
            this.Number = number;
        }

        public string Name { get; set; }
        public int Number { get; set; }

    }
}
