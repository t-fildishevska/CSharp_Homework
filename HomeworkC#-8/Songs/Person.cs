using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Songs
{
    class Person
    {
        //Create a class Person with the following properties: Id, FirstName, LastName, Age, FavoriteMusicType(Genre enum) and FavoriteSongs
        //FavoriteSongs is a list of Songs
        //Create a method called GetFavSongs() that will print out all the titles of their favorite songs or write a message that this person 
        //hates music if there are no favorite songs in their list

        public double Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre FavoriteMusicType { get; set; }
        public List<Song> FavoriteSongs = new List<Song>();

        //public Person(string firstName, string lastName, int age, double id, Genre favoriteMusicType)
        //{
        //    FirstName = firstName;
        //    LastName = lastName;
        //    Age = age;
        //    Id = id;
        //    FavoriteMusicType = favoriteMusicType;
        //}

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        } //too lazy for the rest

        public void GetFavSongs()
        {
            bool hasSongs = FavoriteSongs.Any();
            if (hasSongs)
            {
                foreach (var song in FavoriteSongs)
                {
                    Console.WriteLine(song);
                    Console.WriteLine("-----------------------");
                }
            }
            else
            {
                Console.WriteLine("This person hates music apparently...");
            }
        }
    }
}
