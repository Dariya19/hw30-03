using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Media;

namespace WinFormsApp2
{
    class Play
    {
        private string Play_name;
        public Play(string n) { Play_name = n; } // конструктор
        public string getPlayName() { return Play_name; }

        public void Play_music(string sound_filename)
        {

            // будем проигрывать звук из файла sound_filename
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = sound_filename;
            sp.Load();
            sp.Play();
        }
    }


}
