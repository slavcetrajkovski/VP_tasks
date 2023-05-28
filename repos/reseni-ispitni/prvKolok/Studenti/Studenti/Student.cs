using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studenti
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Index { get; set; }
        public List<File> Files { get; set; }

        public Student(string firstName, string index, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Index = index;
            Files = new List<File>();
        }

        public double average()
        {
            double total = 0;
            foreach (File course in Files)
            {
                total += course.Grade;
            }
            if (Files.Count > 0)
            {
                return total / Files.Count;
            }
            return 0;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2}", FirstName, LastName, Index);
        }
    }
}
