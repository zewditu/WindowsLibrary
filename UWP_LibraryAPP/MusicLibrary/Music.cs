using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary
{
    public class Music
    {        
        public string title { get; set; }
        public string artistName { get; set; }
        public string genra { get; set; }
        public string album { get; set; }
       
        public static Music GetMusic()
        {
            var music = new Music()
            {
                title = "Tikur Sew",
                artistName = "Tedi Afro",
                genra = "Rege",
                album = "Menilik"
            };
            return music;
        }
    }
}
