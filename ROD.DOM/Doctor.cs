using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROD.DOM
{
    internal class Doctor : Person
    {
        protected int work_experience;
        protected string place_of_work;
        protected string specialization;

        public int WorkExperience
        {
            get {return work_experience; }
        }
        public string PlaceOfWork
        { get { return place_of_work;} }
        public string Specialization
        { get { return specialization; } }
        public Doctor(string name,string surname, int birthdayYear, double height,int work_experience, string place_of_work, string specialization)
        {
            this.work_experience = work_experience;
            this.place_of_work = place_of_work;
            this.specialization = specialization;
        }
    } }
