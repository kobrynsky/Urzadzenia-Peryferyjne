using System;
using System.IO;
using System.Windows.Forms;

namespace UP_Lab2_Karta_Dzwiekowa
{
    public partial class MainWindow : Form
    {
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
                //Jak się nie da zatrzymać to nic nie rób 
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
                labelHeaders.Text = SoundCardHandler.GetHeadersAndDetails();
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
            SoundCardHandler.MakeEcho(this, checkBoxEcho);
        }
    }
}
