//using System;
//using System.ComponentModel;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;
//using System.Timers;
//using System.Windows.Forms;
//using Ghostware.NMEAParser;
//using Ghostware.NMEAParser.NMEAMessages;
//using InTheHand.Net.Bluetooth;
//using InTheHand.Net.Sockets;
//using Timer = System.Timers.Timer;
//
//namespace WindowsFormsApp2
//{
//    public partial class Form1 : Form
//    {
//        private string _latitudeFinal;
//        private string _longtitudeFinal;
//        private string _satellitesNumberFinal;
//        private string _altitudeFinal;
//        private string _longMap;
//        private string _latMap;
//        private Stopwatch _stopwatch;
//        private Timer _timer;
//        static readonly BluetoothClient BluetoothClient = new BluetoothClient();
//
//        public Form1()
//        {
//            InitializeComponent();
//            latValue.Text = "";
//            longValue.Text = "";
//            altValue.Text = "";
//            satNumValue.Text = "";
//            timerLabel.Text = "";
//        }
//
//        public void Pair()
//        {
//            //Wyszukanie wszystkich urzadzen
//            var allBtDevices = BluetoothClient.DiscoverDevices();
//
//            //Zabranie urzadzenia o pozadanej nazwie (nadajnik Pentagram)
//            var wantedDevice = allBtDevices.Where(x => x.DeviceName.Equals("PENTA-GPS")).FirstOrDefault();
//            if (wantedDevice != null)
//            {
//                //Parowanie urzadzenia
//                wantedDevice.Update();
//                wantedDevice.Refresh();
//                if (BluetoothSecurity.PairRequest(wantedDevice.DeviceAddress, "0000"))
//                {
//                    MessageBox.Show("Urządzenie sparowane pomyślnie");
//                    //Asynchroniczne polaczenie z urzadzeniem. Po pomyslnym wykonaniu polaczenia przechodzimy do metody Connect
//                    BluetoothClient.BeginConnect(wantedDevice.DeviceAddress, BluetoothService.SerialPort, new AsyncCallback(Connect), wantedDevice);
//                    _timer = new Timer { Interval = (1000) };
//                    _timer.Elapsed += new ElapsedEventHandler(TimerTick);
//                    _stopwatch = new Stopwatch();
//                    _timer.Enabled = true;
//                    _timer.Start();
//                    _stopwatch.Start();
//                }
//                else
//                {
//                    MessageBox.Show("Nie udało się sparować urządzenia.");
//                }
//            }
//        }
//
//        private void Connect(IAsyncResult result)
//        {
//
//
//            if (result.IsCompleted)
//            {
//                //Pobieramy strumien danych z urzadzenia
//                var nsFromDevice = BluetoothClient.GetStream();
//                while (true)
//                {
//                    if (nsFromDevice.CanRead)
//                    {
//                        //Bufor dla odebranej wiadomosci
//                        var bufferMessage = new byte[256];
//                        var completeMessage = new StringBuilder();
//
//                        do
//                        {
//                            var numberOfBytesRead = nsFromDevice.Read(bufferMessage, 0, bufferMessage.Length);
//
//                            completeMessage.AppendFormat("{0}", Encoding.ASCII.GetString(bufferMessage, 0, numberOfBytesRead));
//                        }
//                        while (nsFromDevice.DataAvailable);
//                        try
//                        {
//                            //Parsowanie wiadomosci w formacie NMEA
//                            var nmeaParser = new NmeaParser();
//                            var parsedMessage = (GpggaMessage)nmeaParser.Parse(completeMessage.ToString());
//                            Console.WriteLine("Odebrano następującą wiadomość: " +
//                                                     completeMessage.ToString());
//                            this.ShowParsedMessage(parsedMessage);
//                        }
//                        catch (Exception exc)
//                        {
//                            Console.WriteLine("Wystapil blad, ponowna proba pobrania danych");
//                            Console.WriteLine();
//                        }
//                    }
//                    else
//                    {
//                        Console.WriteLine("Sorry.  You cannot read from this NetworkStream.");
//                    }
//                }
//            }
//        }
//
//        public void ShowParsedMessage(GpggaMessage parsedMessage)
//        {
//            //Szerokosc geograficzna
//
//            //Poszczegolne skladowe wspolrzednych geograficznych
//            var minutes = (parsedMessage.Latitude - Math.Floor(parsedMessage.Latitude)) * 60.0;
//            var seconds = (minutes - Math.Floor(minutes)) * 60.0;
//            var tenths = (seconds - Math.Floor(seconds)) * 10.0;
//
//            //Formatowanie szerokosci na potrzeby wyswietlenie polozenia na mapie
//            _latMap = parsedMessage.Latitude.ToString();
//            _latMap = _latMap.Replace(',', '.');
//
//            //Usuniecie ulamkow
//            minutes = Math.Floor(minutes);
//            seconds = Math.Floor(seconds);
//            tenths = Math.Floor(tenths);
//            _latitudeFinal = Math.Floor(parsedMessage.Latitude) + "° " + minutes + "'" + seconds + "." + tenths;
//
//            //Analogicznie dla dlugosci geograficznej
//
//            minutes = (parsedMessage.Longitude - Math.Floor(parsedMessage.Longitude)) * 60.0;
//            seconds = (minutes - Math.Floor(minutes)) * 60.0;
//            tenths = (seconds - Math.Floor(seconds)) * 10.0;
//
//            _longMap = parsedMessage.Longitude.ToString();
//            _longMap = _longMap.Replace(',', '.');
//
//            minutes = Math.Floor(minutes);
//            seconds = Math.Floor(seconds);
//            tenths = Math.Floor(tenths);
//
//            _longtitudeFinal = Math.Floor(parsedMessage.Longitude) + "° " + minutes + "'" + seconds + "." + tenths;
//
//            //Wysokosc n.p.m.
//            _altitudeFinal = parsedMessage.Altitude + " m.n.p.m.";
//
//            //Liczba satelit
//            _satellitesNumberFinal = parsedMessage.NumberOfSatellites.ToString();
//        }
//
//        private void btShowMap_Click(object sender, EventArgs e)
//        {
//            //Przejscie do Google Maps na znalezionym punkcie
//            wbMap.Navigate("https://www.google.com/maps/?q=" + _latMap + "," + _longMap);
//        }
//
//        private void btPair_Click(object sender, EventArgs e)
//        {
//            //BackgroundWorker odpowiada za aktualizacje informacji na ekranie
//
//            var backgroundWorker = new BackgroundWorker();
//
//
//            backgroundWorker.WorkerReportsProgress = true;
//
//            backgroundWorker.DoWork += new DoWorkEventHandler(
//                delegate (object o, DoWorkEventArgs args)
//                {
//                    var secondaryBw = o as BackgroundWorker;
//
//                    for (int i = 1; i <= 1000; i++)
//                    {
//                        secondaryBw.ReportProgress(i * 10);
//                        Thread.Sleep(1000);
//                    }
//                });
//
//            backgroundWorker.ProgressChanged += new ProgressChangedEventHandler(
//                delegate (object o, ProgressChangedEventArgs args)
//                {
//                    latValue.Text = _latitudeFinal;
//                    longValue.Text = _longtitudeFinal;
//                    altValue.Text = _altitudeFinal;
//                    satNumValue.Text = _satellitesNumberFinal;
//                });
//
//            backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(
//                delegate (object o, RunWorkerCompletedEventArgs args)
//                {
//                    satNumValue.Text = "Finished!";
//                });
//
//            backgroundWorker.RunWorkerAsync();
//            Pair();
//        }
//        void TimerTick(object sender, ElapsedEventArgs e)
//        {
//            timerLabel.BeginInvoke(new MethodInvoker(() => timerLabel.Text = _stopwatch.Elapsed.ToString("mm\\:ss")));
//        }
//    }
//}