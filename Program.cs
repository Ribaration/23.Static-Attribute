using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Static_Attribute
{
    internal class Program
    {
        internal class Songs 
        {
            public string title;
            public string artist;
            public int duration;

            public static int songCount = 0; //Declaration
            public Songs( string aTitle, string aArtist, int aDuration) 
            {
                this.title = aTitle;
                this.artist = aArtist;
                this.duration = aDuration;
                songCount++; //increment each time a song is added
            }
        }
        static void Main(string[] args)
        {
            Songs holiday = new Songs("Holiday", "Green Day", 4);
            Songs KO = new Songs("KO", "Led Zeppelin", 7);

            Console.WriteLine(Songs.songCount);
            Console.ReadLine();

        }
    }
}
