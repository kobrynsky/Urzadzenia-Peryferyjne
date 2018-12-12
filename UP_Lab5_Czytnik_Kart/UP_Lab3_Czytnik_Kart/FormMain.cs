using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCSC;
using PCSC.Exceptions;
using PCSC.Utils;

namespace UP_Lab3_Czytnik_Kart
{
    public partial class FormMain : Form
    {
        private static SCardError error;
        private static SCardReader reader;
        private static System.IntPtr intptr;
        private static SCardContext context;
        private static string hexText;

        //komendy w formie bitowej
        private byte[] commandB;

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {

            byte[] commandB;    //odpowiendie polecenia będą przesyłane do czytnika w formie bitowej.
            try
            {
                Connect();

                //wysłanie kolejnych komend do czytnika, celem programu jest odczytanie SMSa
                //poruszanie sie po poszczególnych poziomach:

                // wejscie w galaz telecom:
                commandB = new byte[] { 0xA0, 0xA4, 0x00, 0x00, 0x02, 0x7F, 0x10 }; // adres złożony z 2 znaków 107F
                SendCommand(commandB, "SELECT(TELECOM)");

                Console.WriteLine("Odpowiedz TELECOMU\n");
                commandB = new byte[] { 0xA0, 0xC0, 0x00, 0x00, 0x0F };
                SendCommand(commandB, "GET RESPONSE");

                // wejscie w galaz SMS     
                commandB = new byte[] { 0xA0, 0xA4, 0x00, 0x00, 0x02, 0x6F, 0x3C };
                SendCommand(commandB, "SELECT SMS");
                Console.WriteLine("Odpowiedz gałęzi SMS\n");
                commandB = new byte[] { 0xA0, 0xC0, 0x00, 0x00, 0x0F };

                // odczyt smsa
                commandB = new byte[] { 0xA0, 0xB2, 0x01, 0x04, 0xB0 };
                SendCommand(commandB, "READ RECORD");
                Console.WriteLine("Odczyt SMS");
                commandB = new byte[] { 0xA0, 0xC0, 0x00, 0x00, 0x0F };
                SendCommand(commandB, "GET RESPONSE");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Podczas uruchamiana programu wystąpił blad: " + ex);
            }
        }

        private void Connect()
        {
            //            context = new SCardContext(); //nawiązanie połączenia z czytnikiem
            //
            //
            //            Console.WriteLine("polaczone: ");
            //            var firstReader = context.GetReaders().FirstOrDefault(); // wczytanie dostępnych czytników do listy
            //            Boolean noReaders = firstReader == null;
            //            if (noReaders)
            //            {
            //                throw new PCSCException(SCardError.NoReadersAvailable, "brak czytnika");
            //            }
            //
            //            reader = new SCardReader(context);

            context = new SCardContext();
            context.Establish(SCardScope.System);
            var readerNames = context.GetReaders();
            reader = new SCardReader(context);
            //context.Release();
            error = reader.Connect(readerNames.FirstOrDefault(), SCardShareMode.Shared, SCardProtocol.T0 | SCardProtocol.T1);
            CheckError(error);
            if (reader.ActiveProtocol == SCardProtocol.T0)
            {
                intptr = SCardPCI.T0;

            }
            else if (reader.ActiveProtocol == SCardProtocol.T1)
            {
                intptr = SCardPCI.T1;
            }
            else
            {
                Console.WriteLine("nie obslugiwany protokol");
            }


            richTextBoxSmsHexResponse.Text = hexText;
        }

        //sprawdzenie czy włożona została karta
        static void CheckError(SCardError error)
        {
            if (error != SCardError.Success)
            {
                MessageBox.Show(SCardHelper.StringifyError(error));
                // throw new PCSCException(error, SCardHelper.StringifyError(error));
            }
        }

        public static void SendCommand(byte[] command, String name) // przesyłanie komend do karty
        {
            hexText = "";
            byte[] recivedBytes = new byte[256];
            error = reader.Transmit(intptr, command, ref recivedBytes);
            CheckError(error);
            WriteResponse(recivedBytes, name);

//            foreach (var recivedByte in recivedBytes)
//            {
//                hexText += recivedByte.ToString();
//            }
        //    hexText = Encoding.Default.GetString(recivedBytes);
        }

        public static void WriteResponse(byte[] recivedBytes, String responseCode)//odczytanie odpowiedzi z karty
        {
            
            Console.Write(responseCode + ": ");
            for (int i = 0; i < recivedBytes.Length; i++)
            {
                Console.Write("{0:X2} ", recivedBytes[i]); // wypisanie odpowiedzi binarnie
              //  hexText += ("{0:X2} ", recivedBytes[i]);
            }

            Console.WriteLine();
        }

    }
}
