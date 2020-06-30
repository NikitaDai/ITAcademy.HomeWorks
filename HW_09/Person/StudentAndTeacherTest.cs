
using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class StudentAndTeacherTest
    {   
        static void Main()
        {
            Person person = new Person();
            person.Hello();

            Student student = new Student(21);
            student.Hello();
            student.ShowAge();

            Teacher teacher = new Teacher(subject : "Math", 30);
            teacher.Hello();
            teacher.Explain();
        }
    }
}
