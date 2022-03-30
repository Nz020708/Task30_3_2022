using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    public class Student
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public int ID   { get; set; }
        public string Profession { get; set; }
       
        public Student(int id,string name,string surname,string profession)
        {
            ID = id;
            Name= name;
            Surname = surname;
            Profession = profession;
        }
    }
}
