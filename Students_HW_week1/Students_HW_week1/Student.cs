using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_HW_week1
{
    public class Student
    {
        //constructors
        public Student(string pFirstName, string pLastName) 
        {
            FirstName = pFirstName;
            LastName = pLastName;
        }

        //properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //fields
        private double[] grades = new double[4] {9, 10, 8, 10};

        //methods
        public double GradeAverage()
        {
            double sum_notes = 0;
            foreach (double grade in grades)
            {
                sum_notes += grade;
            }
            //Console.WriteLine(grades.Length);
            //Console.WriteLine(sum_notes / grades.Length);
            return sum_notes/grades.Length;            

        }
    }
}
