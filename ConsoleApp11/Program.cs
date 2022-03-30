using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(012,"Jane","Dark","Computer Sciences");
            Student student2 = new Student(013,"Mark","Simpson","Computer Sciences");
            Student student3 = new Student(014,"Leon","Poker","Computer Sciences");
            Student student4 = new Student(015,"Anna","Jefferson","Computer Sciences");
           Group group = new Group ( "GrCs",30,student1,student2,student3);
           group.addStu(student4);
            
            
        }
    }
}
