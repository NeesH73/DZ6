using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROD.DOM
{
    abstract class Person
    {
        protected string name;
        protected string surname;
        protected int birthdayYear;
        protected double height;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        { get { return surname; }
          set {  surname = value; }
        }
        public double Height
        { get { return height; }
          set {  height = value; }
        }
        
    }
}
