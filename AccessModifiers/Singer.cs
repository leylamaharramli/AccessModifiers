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
        public byte Age { get; set; }




        public void Limit(string name, string surname, byte age)
        {
            if(name.Length <= 100 && surname.Length <= 100) 
            {
                Console.WriteLine($"Singer's Name: {name}, Singer's Surname: {surname}");
            }
            else
            {
                Console.WriteLine("Name or Surname limit over 100");
            }

            if (age <= 170)
            {
                Console.WriteLine($"Age: {age}");
            }
            else
            {
                Console.WriteLine("Age limit over 170");
            }

        }
    }
}
