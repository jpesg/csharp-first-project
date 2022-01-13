using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    
    class Song
    {
        public string title;
        public string artist;
        public int duration;
        public static int songCount = 0;
        public Song(string aTitle, string aArtist, int aDuration) {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;

            songCount++;//update counter very time a song is created
        }
      
    }
}
