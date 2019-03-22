using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Songs
{
    class Song
    {
        //Create a class Song with the following properties: Title, Length and, Genre
        //Genre is enum with - Rock, Hip_Hop, Techno and Classical
        public string Title { get; set; }
        public double Length { get; set; }
        public Genre Genre { get; set; }

        public Song(string title, double length, Genre genre)
        {
            Title = title;
            Length = length;
            Genre = genre;
        }

        public override string ToString()
        {
            return $"Title: {Title}\nLength: {Length}\nGenre: {Genre}";
        }

    }
}
