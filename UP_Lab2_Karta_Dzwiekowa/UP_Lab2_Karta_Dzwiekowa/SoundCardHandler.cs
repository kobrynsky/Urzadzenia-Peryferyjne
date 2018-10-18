using System;
using System.IO;
using System.Media;
using SharpDX.DirectSound;
using SharpDX.Multimedia;

namespace UP_Lab2_Karta_Dzwiekowa
{
    static  class  SoundCardHandler
    {
        private const int NumberChannels = 2;
        private const int SamplesPerSecs = 44100;

        public static string  FilePath { get; set; }
        public static string FileName { get; set; }
        public static System.Media.SoundPlayer Player;  

        public static void Play()
        {
            Player = new System.Media.SoundPlayer(FilePath);
            Player.Play();
        }

        public static void Stop()
        {
            Player.Stop();
        }
    }
}
