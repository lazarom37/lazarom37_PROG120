using System;
using System.Collections.Generic;

namespace ListEnumHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Students[] newStudents = new Students[6];

            newStudents[0] = new GradeSchool(Colors.blue, "Smith");
            newStudents[1] = new GradeSchool(Colors.green, "Jones");
            newStudents[2] = new HighSchool(Colors.red, "Lee");
            newStudents[3] = new HighSchool(Colors.blue, "Yee");
            newStudents[4] = new College(Colors.green, "Adelaida");
            newStudents[5] = new College(Colors.red, "Rossi");
            
            List<Students> kids = new List<Students>();

            for(int i = 0; i < newStudents.Length; i++)
            {
                kids.Add(newStudents[i]);
            }

            foreach (Students item in kids)
            {
                Console.WriteLine($"last name is {item.LastName}");
            }

            Console.WriteLine(); //spacer
            
            List<College> adults = new List<College>();
            adults.Add((College)newStudents[4]);
            adults.Add((College)newStudents[5]);

            foreach (College item in adults)
            {
                Console.WriteLine($"last name is {item.LastName}, class size is {item.Size}, favorite color is {item.FavoriteColor}");
            }
            
        }
    }
}
