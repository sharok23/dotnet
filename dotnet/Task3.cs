using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet
{
    public class GradeManagement
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the grades");
            var grades = new int[5];
            var n = grades.Length;
            for (int i = 0; i < n; i++)
            {
                grades[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(", ", grades));

             var sum = 0;
            for (int i = 1;i < n; i++)
            {
                sum += grades[i];
            }
            var average = sum/n;
            Console.WriteLine("Class average is: {0}",average);
            
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (grades[i] > grades[j])

                    {
                        var temp = grades[i];
                        grades[i] = grades[j];
                        grades[j] = temp;
                    }
                }
            }
            Console.WriteLine("Class highest grade is: {0}", grades[n-1]);
            Console.WriteLine("Class lowest grade is: {0}", grades[0]);


            var students = 0;
            for(int i = 0;i < n; i++)
            {
                if (grades[i] >= 50)
                {
                    students += 1;
                }
            }
            Console.WriteLine("Students passed is: {0}",students);
            Console.WriteLine("Students failed is: {0}", n-students);

           

        }
    }
    
}
