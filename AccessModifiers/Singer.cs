using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Singer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Age { get; set; }



        public Singer(string name, string surname, string age) 
        {
            Name = name;
            Surname = surname;
            Age = age;
        }


        public void Limit(string name, string surname, string age)
        {
            if(name.Length > 100 || surname.Length > 100) 
            {
                Console.WriteLine("Ad ve ya Soyadin limiti 100u ashib");
            }

            if(age.Length > 100)
            {
                Console.WriteLine("Yasin limiti 100u ashib");
            }

        }
    }
}
