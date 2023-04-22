using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsVar_6
{
    public class Spisoc
    {
        public List<AllGruppa> allGruppas { get; private set; }
        public void Initialize()
        {
            allGruppas = new List<AllGruppa>
            {
                new AllGruppa(new Students("Man"), new Gruppa("is11"))
                new AllGruppa(new Students("Female"), new Gruppa("is12"))
                new AllGruppa(new Students("Stud"), new Gruppa("is13"))
            };
            
        }
    }
}
