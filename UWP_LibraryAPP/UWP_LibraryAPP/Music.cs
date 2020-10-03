using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP_LibraryAPP
{
    public class Music // it is not a picture/video
    {
        /// <summary>
        /// Fields
        /// </summary>     
        private string title;  // Tamoleshal
        private string artistName; // Tedi
        private string album;  // Ethiopia 
        private string genra;  // Rege

        /// <summary>
        /// Getters
        /// </summary>
        /// <returns></returns>
        //public string GetTitle() { return this.Title; }
        //public string GetArtist() { return this.Artist; }
        //public string GetAlbum() { return this.Album; }
        //public string GetGenra() { return this.Genra; }

        public string Title
        {
           get =>this.title; 
           set => this.title = value; 
        }
        public string Artist
        {
            get => this.artistName;
            set => this.artistName = value;
        } 
        //public string Album
        //{
        //    get { return this.album; }
        //    set { this.album = value; }
        //}
        /// <summary>
        /// setters
        /// </summary>
        //public void SetTitle(string title) { this.Title = title; }
        //public void SetArtist(string artist) { this.Artist = artist; }
        //public void SetAlbum(string album) { this.Album = album; }
        //public void SetGenra(string genra) { this.Genra = genra; }

        /// <summary>
        /// Methods
        /// </summary>
        public void Play() { }
        public void Stop() { }
        public void Pouse() { }
    }
}
