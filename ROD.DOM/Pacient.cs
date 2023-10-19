using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROD.DOM
{
    internal class Pacient:Person
    {
        protected int howlonginhospital;
        protected string namedoctor;
        protected string surnamedoctor;
        public int HowlonginHospital
        {
            get { return howlonginhospital; }
        }
        public string Namedoctor
        { get { return namedoctor; } }
        public string Surnamedoctor
        { get { return surnamedoctor; } }
        public void GestationPeriod(int srok)
        {
            if (srok>9)
            {
                Console.WriteLine($"Ребенок родился {srok - 9} месяц(ов) назад");
            }
            else
            {
                Console.WriteLine($"Беременность {srok} месяц(ов)");
            }
        }
        public Pacient(int howlonginhospital, string namedoctor, string surnamedoctor, string name, string surname, double height, int birthdayYear)
        {
            this.howlonginhospital = howlonginhospital;
            this.namedoctor = namedoctor;
            this.surnamedoctor = surnamedoctor;
           
        }
    }
}
