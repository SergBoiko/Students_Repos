using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_ClassLibrary
{
    public class Teacher
    {
        public List<Group> Groups;

        public Teacher(string name, int age)
        {
            Groups = new List<Group>();
            this.Name = name;
            this.Age = age;
            
        }

        public string Name { get; set; }
        public int Age { get; set; }
        
    }
}
