using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a class Song with the following properties: Title, Length and, Genre
            //Genre is enum with - Rock, Hip_Hop, Techno and Classical
            //Create a class Person with the following properties: Id, FirstName, LastName, Age, FavoriteMusicType(Genre enum) and FavoriteSongs
            //FavoriteSongs is a list of Songs
            //Create a method called GetFavSongs() that will print out all the titles of their favorite songs or write a message that this person 
            //hates music if there are no favorite songs in their list

            var tedi = new Person("tedi", "fildishevska");
            Console.WriteLine("With empty list:");
            tedi.GetFavSongs();

            Console.WriteLine();
            Console.WriteLine("With full list:");
            tedi.FavoriteSongs = DemoSongs();
            tedi.GetFavSongs();

        }

        static List<Song> DemoSongs()
        {
            List<Song> demo = new List<Song>();
            var song1 = new Song("song1", 3.5, Genre.Hip_Hop);
            demo.Add(song1);
            var song2 = new Song("song2", 4, Genre.Rock);
            demo.Add(song2);
            var song3 = new Song("song3", 2.7, Genre.Techno);
            demo.Add(song3);
            var song4 = new Song("song4", 5.3, Genre.Rock);
            demo.Add(song4);
            var song5 = new Song("song5", 7, Genre.Classical);
            demo.Add(song5);

            return demo;
        }
    }
}
