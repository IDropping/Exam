using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsVar_6
{
    public class AllGruppa
    {
        private Students _surname;
        private Gruppa _gruppa;
        public Students Student
        {
            get => _surname;
        }
        public string surname
        {
            get { return Student != null ? Student.surname : ""; }
        }
        public Gruppa gruppa
        {
            get => _gruppa;
        }
        public string gruppas
        {
            get { return gruppa != null ? gruppa.gruppa : ""; }
        }
        private AllGruppa(string stud, string grupp)
        {
            stud = _surname;
            grupp = _gruppa;
        }
    }
}
