using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsVar_6
{
    public class Gruppa
    {
        public string _gruppa;
        public string gruppa
        {
            get => _gruppa;
            private set => _gruppa = value;
        }
        public Gruppa(string gruppa)
        {
            _gruppa = gruppa;
        }
    }
}
