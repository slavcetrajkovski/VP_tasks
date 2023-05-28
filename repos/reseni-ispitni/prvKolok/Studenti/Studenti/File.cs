using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Studenti
{
    public class File
    {
        public int Subject {get; set;}
        public int Grade { get; set; }
        public Random random = new Random();

    
        public File(int subject)
        {
            Subject = subject;
            Grade = 0;
        }

        

        public override string ToString()
        {
            return String.Format("Предмет {0} ({1})", Subject, Grade);
        }
    }
}
