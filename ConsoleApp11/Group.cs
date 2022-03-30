using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    public class Group
    {
        public string GroupName { get; set; }
        public int MaxStuCount { get; set; }
        public Student[] Students { get; set; }
      
        public Group(string groupname,int maxstucount, params Student[] Students)
        {
            GroupName = groupname;
            MaxStuCount = MaxStuCount;
            this.Students = Students;
        }
        public void addStu(Student student)
        {
            if (MaxStuCount == Students.Length+1) 
                
            {
                Console.WriteLine("Qrupda yer yoxdur.");
            }
           
             Student[] Group = new Student[Students.Length+1];
            Group[Group.Length - 1] = student;
            for (int i = 0;  i<Students.Length; i++)
            {

                Group[i] = Students[i];
                
            }
            Console.WriteLine("Student elave edildi.");
            foreach (var item in Group)
            {
                Console.WriteLine($"Ad: {item.Name}  Soyad: {item.Surname}  Ixtisas: {item.Profession}  ID: {item.ID}");
            }
            
        }
        public void RemoveStu(string group)
        {
            if (group.Length>MaxStuCount)
            {

            }
        }
    }

}
