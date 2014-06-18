using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public static class StudentUtils
    {
        public static string OlderStudentName(Student firstStudent, Student secondStudent)
        {
            if (firstStudent.BirthDate > secondStudent.BirthDate)
            {
                return firstStudent.FirstName;
            }
            else
            {
                return secondStudent.FirstName;
            }
        }
    }
}
