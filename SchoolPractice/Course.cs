using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    public class Course //each course has a CourseNo, List of Student.cs and Teacher.cs
    {
        private int CourseNo {get; set; }
        private List<Student> Student = new List<Student>();
        private Teacher cTeacher { get; set; }

        //constructor
        public Course(int courseNo, List<Student> student, Teacher cTeacher)
        {
            CourseNo = courseNo;
            Student = student;
            this.cTeacher = cTeacher;
        }
    }
}