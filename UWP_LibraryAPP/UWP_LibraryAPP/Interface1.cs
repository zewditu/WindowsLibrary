using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP_LibraryAPP
{
    public interface IMusic
    {
        void Play();
        void Stop(); 
        void Pouse();
        void Forword();
        void Backword();
        void Replay();
    }
}
