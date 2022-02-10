using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class User
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Patronymic { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Phone { get; set; }

        public string Birthday { get; set; }

        public bool IsMale { get; set; }

        public User(string name, string surname, string patronymic, string country, 
            string city, string phone, string birthday, bool isMale)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Country = country;
            City = city;
            Phone = phone;
            Birthday = birthday;
            IsMale = isMale;
        }
    }
}
