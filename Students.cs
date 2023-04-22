using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsVar_6
{
    public class Students
    {
        public string _surname;
        public string surname
        {
            get => _surname;
            private set => _surname = value;
        }
        public Students(string surname)
        {
            _surname = surname;
        }
    }
}
