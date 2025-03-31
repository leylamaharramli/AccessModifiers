using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class Song
    {
        public string Name { get; set; }
        public string Genre { get; set; }



        public void Max(string name, string genre)
        {
            if (name.Length > 100)
            {
                Console.WriteLine("Name limit over 100");
            }
            else
            {
                Console.WriteLine($"Name of Song: {name}");
            }

            if (genre == "Pop" || genre == "Rock" || genre == "Jazz" || genre == "Techno")
            {
                Console.WriteLine($"Genre: {genre}"); 
            }
            else
            {
                Console.WriteLine("Entered genre does not exist in the system");
            }
        }

        float RatingSum = 0;
        int RatingCount = 0;
        public void AddRating(int rating)
        {
            RatingSum += rating;
            RatingCount++;
            Console.WriteLine($"Rating added successfully: {rating}");

        }

      

        public void GetAverageRating()
        {
            
            Console.WriteLine($"Average Rating: {RatingSum / RatingCount}");
        }
    }
}
