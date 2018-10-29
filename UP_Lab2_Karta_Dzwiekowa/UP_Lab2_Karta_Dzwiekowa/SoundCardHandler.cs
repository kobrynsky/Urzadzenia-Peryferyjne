using System.IO;
using System.Media;
using System.Windows.Forms;
using SlimDX.DirectSound;
using SlimDX.Multimedia;
using BufferFlags = SlimDX.DirectSound.BufferFlags;
using CooperativeLevel = SlimDX.DirectSound.CooperativeLevel;
using DirectSound = SlimDX.DirectSound.DirectSound;
using SecondarySoundBuffer = SlimDX.DirectSound.SecondarySoundBuffer;
using SoundBufferDescription = SlimDX.DirectSound.SoundBufferDescription;

namespace UP_Lab2_Karta_Dzwiekowa
{
    public class SoundCardHandler
    {
        public static string FilePath { get; set; }
        public static SoundPlayer Player;

        public static void Play()
        {
            Player = new SoundPlayer(FilePath);
            Player.Play();
        }

        public static void Stop()
        {
            Player.Stop();
        }

        public static string GetHeadersAndDetails()
        {
            var header = new WaveHeader();

            using (var fileStream = new FileStream(FilePath, FileMode.Open, FileAccess.Read))
            using (var binaryReader = new BinaryReader(fileStream))
            {
                try
                {
                    //pobiera kolejno dane pliku .wav
                    header.riffID = binaryReader.ReadBytes(4);
                    header.size = binaryReader.ReadUInt32();
                    header.wavID = binaryReader.ReadBytes(4);
                    header.fmtID = binaryReader.ReadBytes(4);
                    header.fmtSize = binaryReader.ReadUInt32();
                    header.format = binaryReader.ReadUInt16();
                    header.channels = binaryReader.ReadUInt16();
                    header.sampleRate = binaryReader.ReadUInt32();
                    header.bytePerSec = binaryReader.ReadUInt32();
                    header.blockSize = binaryReader.ReadUInt16();
                    header.bit = binaryReader.ReadUInt16();
                    header.dataID = binaryReader.ReadBytes(4);
                    header.dataSize = binaryReader.ReadUInt32();
                }
                finally
                {
                    binaryReader.Close();
                    fileStream.Close();
                }
            }
            return header.ToString();
        }

        public static void MakeEcho(MainWindow  window, CheckBox checkBoxEcho)
        {
            if (!string.IsNullOrEmpty(FilePath))
            {
                using (var file = new WaveStream(FilePath))
                {
                    var desc = new SoundBufferDescription
                    {
                        SizeInBytes = (int) file.Length,
                        Flags = BufferFlags.ControlEffects,
                        Format = file.Format
                    };


                    var directorySound = new DirectSound();
                    directorySound.SetCooperativeLevel(window.Handle,
                                                        CooperativeLevel.Priority);

                    var secondarySoundBuffer = new SecondarySoundBuffer(directorySound, desc);

                    if (checkBoxEcho.Checked)
                    {
                        var echo = SoundEffectGuid.StandardEcho;
                        var guids = new[] { echo };
                        secondarySoundBuffer.SetEffects(guids);

                        var data = new byte[desc.SizeInBytes];
                        file.Read(data, 0, (int)file.Length);

                        secondarySoundBuffer.Write(data, 0, LockFlags.None);
                        secondarySoundBuffer.Play(0, PlayFlags.None);

                        checkBoxEcho.Enabled = false;
                    }
                }
            }
        }
    }
}
