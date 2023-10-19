using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROD.DOM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pacient person1 = new Pacient(2,"Валерий","Волков","Мария", "Салахова",176,2000);
            person1.GestationPeriod(8);
            Doctor person2 = new Doctor("Валерий", "Волков", 1980, 180, 5, "Больница 1", "Хирург");
            Hospital location = new Hospital(123, 43, "Г.Казань, ул.Кремлевская 12");
            Console.WriteLine($"Пациентка {person1.Name} {person1.Surname} находится в больнице {person2.PlaceOfWork} по адресу {location.Location} уже {person1.HowlonginHospital} месяца " +
                $"под присмотром доктора {person1.Namedoctor} {person1.Surnamedoctor} ");
        }
    }
}
