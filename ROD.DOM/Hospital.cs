using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROD.DOM
{
    internal class Hospital
    {
        protected int countPacient;
        protected int countDoctor;
        protected string location;

        public int CountPacient
        {
            get { return countPacient; }
            set { countPacient = value; }
        }
        public int CountDoctor
        {   get { return countDoctor; } 
            set { countDoctor = value; } 
        }
        public string Location 
        {
            get { return location; }
            set { location = value; }
        }
        public Hospital(int countPacient, int countDoctor, string location)
        {
            this.location = location;
            this.countPacient = countPacient;
            this.countDoctor = countDoctor;
        }
    }
}
