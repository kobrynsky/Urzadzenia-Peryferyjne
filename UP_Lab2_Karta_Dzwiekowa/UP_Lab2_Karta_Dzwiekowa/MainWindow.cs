using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlimDX.DirectSound;
using SlimDX.Multimedia;

namespace UP_Lab2_Karta_Dzwiekowa
{
    public partial class MainWindow : Form
    {
        public static string FilePath { get; set; }
        private byte[] buffer;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            try
            {
                SoundCardHandler.Play();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Nie można wczytać załadowanego pliku!",
                    @"Uwaga",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
            }
        }

        private void WindowsMediaPlayer_Enter(object sender, EventArgs e)
        {

        }

        private void buttonChoseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = @"Wave FIle (*.wav)|*.wav;";
            if (fileDialog.ShowDialog() != DialogResult)
            {
                SoundCardHandler.FilePath = fileDialog.InitialDirectory + fileDialog.FileName;

                //zeby wyswietlalo
                labelFileName.Text = Path.GetFileName(fileDialog.FileName);

                //do komponentu windows media player
                WindowsMediaPlayer.URL = SoundCardHandler.FilePath;

                //do echo
                buffer = File.ReadAllBytes(SoundCardHandler.FilePath);
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            try
            {
                SoundCardHandler.Stop();
            }
            catch (Exception)
            {
                //Jak się nie da zastopować to trudno 
            }
        }

        private void buttonSpeedUp_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer.settings.rate = WindowsMediaPlayer.settings.rate + 0.5;
        }

        private void buttonSlowDown_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer.settings.rate = WindowsMediaPlayer.settings.rate - 0.5;
        }

        private void buttonShowHead_Click(object sender, EventArgs e)
        {
            try
            {
                // var stream = File.OpenRead(SoundCardHandler.FilePath);
                //                byte[] wav = File.ReadAllBytes(SoundCardHandler.FilePath);
                //                byte[] data = File.ReadAllBytes(SoundCardHandler.FilePath);
                //                MemoryStream ms = new MemoryStream(data);
                //  var byteArray = ms.ToArray();
                //                var asciiArray = Encoding.ASCII.GetString(wav);
                //                string headers = "";
                //
                //
                //                if (asciiArray.Contains("RIFF"))
                //                    headers += "\n" + "RIFF";
                //                if (asciiArray.Contains("WAVE"))
                //                    headers += "\n" + "WAVE";
                //                if (asciiArray.Contains("fmt"))
                //                    headers += "\n" + "fmt";
                //                if (asciiArray.Contains("data"))
                //                    headers += "\n" + "data";
                //                if (asciiArray.Contains("Title"))
                //                    headers += "\n" + "Title";
                //
                //                labelHeaders.Text = headers;


                WavHeader Header = new WavHeader();

                using (FileStream fs = new FileStream(SoundCardHandler.FilePath, FileMode.Open, FileAccess.Read))
                using (BinaryReader br = new BinaryReader(fs))
                {
                    try
                    {
                        Header.riffID = br.ReadBytes(4);
                        Header.size = br.ReadUInt32();
                        Header.wavID = br.ReadBytes(4);
                        Header.fmtID = br.ReadBytes(4);
                        Header.fmtSize = br.ReadUInt32();
                        Header.format = br.ReadUInt16();
                        Header.channels = br.ReadUInt16();
                        Header.sampleRate = br.ReadUInt32();
                        Header.bytePerSec = br.ReadUInt32();
                        Header.blockSize = br.ReadUInt16();
                        Header.bit = br.ReadUInt16();
                        Header.dataID = br.ReadBytes(4);
                        Header.dataSize = br.ReadUInt32();
                    }
                    finally
                    {
                        if (br != null)
                        {
                            br.Close();
                        }
                        if (fs != null)
                        {
                            fs.Close();
                        }
                    }
                }

                labelHeaders.Text = Header.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Nie można wczytać załadowanego pliku!",
                    @"Uwaga",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
            }
        }



        private void checkBoxEcho_CheckedChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SoundCardHandler.FilePath))
            {
                using (WaveStream file = new WaveStream(SoundCardHandler.FilePath))
                {
                    var desc = new SoundBufferDescription();
                    desc.SizeInBytes = (int)file.Length;
                    desc.Flags = BufferFlags.ControlEffects;
                    desc.Format = file.Format;


                    var directorySound = new DirectSound();
                    directorySound.SetCooperativeLevel(this.Handle, CooperativeLevel.Priority);

                    var secondarySoundBuffer = new SecondarySoundBuffer(directorySound, desc);

                    if (checkBoxEcho.Checked)
                    {
                        var echo = SoundEffectGuid.StandardEcho;
                        var guids = new[] { echo };

                        secondarySoundBuffer.SetEffects(guids);
                        byte[] data = new byte[desc.SizeInBytes];
                        file.Read(data, 0, (int)file.Length);
                        secondarySoundBuffer.Write(data, 0, LockFlags.None);
                        secondarySoundBuffer.Play(0, PlayFlags.None);

                        checkBoxEcho.Enabled = false;
                    }
                }
            }
        }
    }

    struct WavHeader
    {
        public byte[] riffID;
        public uint size;
        public byte[] wavID;
        public byte[] fmtID;
        public uint fmtSize;
        public ushort format;
        public ushort channels;
        public uint sampleRate;
        public uint bytePerSec;
        public ushort blockSize;
        public ushort bit;
        public byte[] dataID;
        public uint dataSize;

        public override string ToString()
        {
            string tempChannel;
            if (channels == 1)
                tempChannel = "mono";
            else if (channels == 2)
                tempChannel = "stereo";
            else
            {
                tempChannel = "unrecognized";
            }


            return "riffID: " + riffID + "\n" +
                   "size: " + size + "\n" +
                   "fmtSize: " + fmtSize + "\n" +
                   "dataSize: " + dataSize + "\n" +
                   "sampleRate: " + sampleRate + "\n" +
                   "channel: " + channels + " " + tempChannel + "\n";
        }
    }
}
