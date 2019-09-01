using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Students_ClassLibrary;

namespace Students_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var newStudent = new Student("Vlad", 22, "Lions");
            var newGroup = new Group("Lions", 3);
            newGroup.Students.Add(newStudent);

            foreach (Student student in newGroup.Students)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Group: {student.Group}");
            }

            var newTeacher = new Teacher("Aleksandr Petrovich", 46);
            newTeacher.Groups.Add(newGroup);

            Console.WriteLine($"Name: { newTeacher.Name}, Age: { newTeacher.Age}");

            foreach(Group group1 in newTeacher.Groups)
            {
                Console.WriteLine($"Name: {group1.Name}, Age: {group1.Number}"); 
            }

            List<Teacher> teacherNew = new List<Teacher>();

            teacherNew.Add(newTeacher);

            var newStudent2 = new Student("Dima", 19, "Managers");
            var newGroup2 = new Group("Managers", 5);
            newGroup2.Students.Add(newStudent2);

            foreach (Student student2 in newGroup2.Students)
            {
                Console.WriteLine($"Name: {student2.Name}, Age: {student2.Age}, Group: {student2.Group}");                
            }

            var newTeacher2 = new Teacher("Vasyliy Olegovich", 52);
            newTeacher.Groups.Add(newGroup);

            Console.WriteLine($"Name: { newTeacher2.Name}, Age: { newTeacher2.Age}");

            foreach (Group group2 in newTeacher2.Groups)
            {
                Console.WriteLine($"Name: {group2.Name}, Age: {group2.Number}");
            }

            Console.ReadLine();
        }
    }
}
