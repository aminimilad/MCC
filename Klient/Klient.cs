using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Klient
{
    public partial class Klient : Form
    {
        //Skapar en ny klient
        TcpClient klient = new TcpClient();
        //Yomma variabler
        int port;
        IPAddress adress;

        public Klient()
        {
            InitializeComponent();
            //Skickaknappen är avstängd för att inte orsaka fel
            btnSend.Enabled = false;
        }
        private void btnAnslut_Click(object sender, EventArgs e)
        {
            //När anslutknappen klickas körs metoden nedan
            Connect();
        }

        private async void Connect()
        {
            //Läser in IP adressen
            try
            {
                 adress = IPAddress.Parse(tbxIP.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Skriv in en giltig IP-adress");
            }

            //Läser in portnumret
            try
            {
                port = int.Parse(tbxPort.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Skriv in ett giltigt portnummer mellan 1024 och 65535");
            }
            try
            {
                //Inväntar att anslutningen görs, andra delar av koden körs under tiden. Förrebygger krasch
                await klient.ConnectAsync(adress, port);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text);
                return;
            }
            //Om klienten är ansluten...
            if (klient.Connected)
            {
                //Stäng av följande knappar
                btnAnslut.Enabled = false;
                btnSend.Enabled = true;
                tbxNmn.Enabled = false;
                tbxMedd.Focus();
            }
            //Avlyssnar
            StartReading(klient);
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            if (klient.Connected)
            {
                //Läs av namnet
                string namn = tbxNmn.Text;
                //Tid
                string tid = DateTime.Now.ToString("HH:mm tt");

                //Om meddelandefältet är tomt..
                if (String.IsNullOrEmpty(tbxMedd.Text) || String.IsNullOrWhiteSpace(tbxMedd.Text))
                {
                    MessageBox.Show("Skriv in ditt meddelande");
                }
                //Annars...
                else
                {
                    //Utdatans struktur
                    byte[] utData = Encoding.Unicode.GetBytes("<" + " " + namn + " " + ">" + "  " + tid + ":" + "\t" + tbxMedd.Text + "\r\n");
                    try
                    {
                        //Testa appenda/lägg till denna text som en utdata till andra klienter
                        tbxLogg.AppendText("<" + " " + namn + " " + ">" + "  " + tid + ":" + "\t" + tbxMedd.Text + "\r\n");

                        //Inväntar med att skicka ström. Andra delar i metoden körs ej,
                        //dock utanför metoden pågår processen, utan att datorn kraschar
                        await klient.GetStream().WriteAsync(utData, 0, utData.Length);

                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message, Text);
                        return;
                    }
                }
            }
            //Rensar meddelanderutan
            tbxMedd.Clear();
        }
        public async void StartReading(TcpClient k)
        {
            //Ger buffern ett värde
            byte[] buffer = new byte[1024];

            int n = 0;
            try
            {
              // Andra delen i metoden kommer inte köras tills buffern fått ett värde mellan 0-1024
                n = await k.GetStream().ReadAsync(buffer, 0, 1024); 
               
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text);
                return;
            }
            //Skriver ut i klientens egna logg
            tbxLogg.AppendText(Encoding.Unicode.GetString(buffer, 0, n));
            
            //Anropar samma metod för att återupprepa samma procedur för kommande datan
            StartReading(k);
        }
        private void Klient_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Stänger av klient
            if (klient != null)
                klient.Close();
        }
    }
}
