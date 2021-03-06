﻿
using WMPLib;

namespace OscarPlayer
{
    class MP3Player:IPlayer
    {
        private WMPLib.WindowsMediaPlayer _objPlayer;

        public MP3Player()
        {
            _objPlayer = new WindowsMediaPlayerClass();
        }


        public void PlaySound(string url)
        {
            _objPlayer.URL = url;
            _objPlayer.controls.play();
        }

        public void PauseSound()
        {
            if (_objPlayer != null)
            {
                _objPlayer.controls.pause();
            }
        }

        public void ResumeSound()
        {
            if (_objPlayer != null)
            {
                _objPlayer.controls.play();
            }
        }

        public void StopSound()
        {
            if (_objPlayer != null)
            {
                _objPlayer.controls.stop();
            }
            
        }

    }
}
