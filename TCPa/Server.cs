using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace TCPa
{   // skapar en lista med tcp clients 
    // säg till så att send funktioner tar tcp clients som input i metoderna och referera till metoderna
    // och loopa genom listan, som kallar metoden i lista.


    public partial class Server : Form
    {
        TcpClient klient = null;
        //Skapar listan "klientLista" med TcpClient som datatyp
        List<TcpClient> klientLista = new List<TcpClient>();
        Dictionary<int, TcpClient> KHM = new Dictionary<int, TcpClient>();
        //Skapar en tom variabel, lyssnare, med TcpListener som datatyp
        TcpListener lyssnare;
        int port = 0;
        int size = 0;
        NetworkStream s;
        public Server()
        {
            InitializeComponent();
            lblA.Text = "0";
        }
        private void btnTaEmot_Click(object sender, EventArgs e)
        {
            //Försök exekvera nedanstående kod...
            try
            {
                //Läser av tbxPort vars innehåll är portnumret som används för att adressera till samma program //////
                port = int.Parse(tbxPort.Text);
                //Om det inmatade portnumret är större än 1024 och mindre än 65535... (det maximala)
                //(rekommenderade minsta portnummer 1024, förebygger risken att inte välja upptagna portar)
                if (port >= 1024 && port <= 65535)
                {
                    //...Så ska metoden "StartListening" anropas, samtidigt som anropandet skickar värdet av 
                    //Variabeln port. Startlistening metoden tar emot en integer, vars innehåll avläses av Parsekoden ovan
                    StartListening(port);
                }
                //Om det inmatade portnumret inte är i ovanstående intervall..
                else
                {
                    //...så ska följande meddelande skrivas ut
                    MessageBox.Show("Skriv in ett giltigt portnummer mellan 1024 och 65535");
                }
            }
            //Om koden i "try-blocket" inte exekveras.. (vid fall av inmatning med felaktiga tecken) 
            catch (Exception)
            {
                //...Så ska följande meddelande skrivas ut
                MessageBox.Show("Skriv in ett giltigt portnummer mellan 1024 och 65535");
            }

        }
        // Metoden nedan tar emot en parameter, int, som bifogas av anropning av eventet ovan

        public void StartListening(int portT)
        {
            //När inmatningen av portnumret är korrekt så ska både..
            //"Ta emot" knappen stängas av..
            btnTaEmot.Enabled = false;
            //Och detsamma gäller för inmatningsfältet för portnummer
            tbxPort.Enabled = false;

            //Testa exekvera...
            try
            {
                //Den tomma variabeln ovanför public Server(), "lyssnare", tilldelas med 
                //TCP listener och tillelas med funktionen tar emot en klient med vilken lokal IP adress som helst
                lyssnare = new TcpListener(IPAddress.Any, portT);
                // Sedan sätts lyssnare igång, lyssnar på inkommande förfrågningar
                lyssnare.Start();
            }
            //Om inte kodblocket ovan exekveras ordentligt så körs nedanstående kodblock. 
            //(söker efter fel)
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text);
                return;
            }
            //Kör metoden Start accepting
            StartAccepting();
        }
        public async void StartAccepting()
        {
            //Testa exekvera...
            try
            {
                //Referensvariabeln klient har inget värde.. Värdet är adressen till den klienten den tilldelas
                //Variabeln inväntar att bli tilldelad ett värde
                //Med await förhindrar man krascher då datorn kan utföra andra processer i bakgrunden 
                //samt invänta meddelande utan att behöva krascha. 
                klient = await lyssnare.AcceptTcpClientAsync();
                //Lägg till en klient i listan

                // klientLista.Add(klient); // SUDD
                KHM[size] = klient;
                size++;
                //lblA.Text = klientLista.Count.ToString();
                lblA.Text = KHM.Count.ToString();
               
                
            }
            //Om inte kodblocket ovan exekveras ordentligt så körs nedanstående kodblock. 
            catch (Exception error)
            {
                //Meddelande med errortext skrivs ut
                MessageBox.Show(error.Message, Text);
                //med return hoppar avläsningen ut från kodblocket
                return;
            }

            //Anropar metoden StartReading med referensvariabeln "klient"
            Task task = StartReading(klient);
            StartAccepting();
        }
        //Startreading metoden fångar klientvariabeln med parametern "k"
        public async Task StartReading(TcpClient k)
        {
            await Task.Delay(500);
            //Buffervariabeln sparar information som kan maximalt hantera 1024 bytes.  
            byte[] buffer = new byte[1024];
            //variabeln "n" tilldelas värdet 0
            int p = 0;
            //Testa exekvera
            //PING

            try
            {
                //variabeln n tar emot textstringen som har avlästs från meddelandefältet
                //Delarna utanför detta block kommer inte att köras förens n tilldelas ett värde mellan 0-1024.
                //Om inget meddelande tas emot som kommer metoden "startAccepting" att köras. Samtidigt kommer 
                //kodraden nedan invänta ett svar på inkommande meddelande i bakgrunden. Såfort ett meddelande
                //Inkommer så kommer raden nedan återupptas.
                if (k.Connected)
                {
                    p = await Task.Run(() => GetVAsync(k, buffer));
                }

            }
            //Vilken IP
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            //Nedanstående anrop görs för att servern ska kunna skicka vidare sträng till de resterande 
            //Uppkopplade klienter. Startsending metoden anropas med klienten, "k", och utskriften som argument

            StartSending(k, Encoding.Unicode.GetString(buffer, 0, p));
            //Samma meddelande som skickas till andra klienter genom servern (anropet ovan), skrivs även ut
            //i serverns meddelandelogg.
            tbxLogg.AppendText(Encoding.Unicode.GetString(buffer, 0, p));

            //Efter anropet har gjorts på startsending loopas startreading funktionen.
            StartReading(k).GetAwaiter();

        }
        //Metoden nedan tar emot klienten, "k", som argument med variabeln "klientSomSkickar",
        //Samt meddelandet som ska, genom servern, skickas vidare till andra uppkopplade klienter 


        private async Task<int> GetVAsync(TcpClient k, byte[] buffer)
        {
            int n = 0;
            if (k.Connected)
            {

                NetworkStream c = k.GetStream();
                while (c.DataAvailable)
                {
                    n = await c.ReadAsync(buffer, 0, 1024);
                }

            }
            return n;
        }


        public async void StartSending(TcpClient klientSomSkickar, string message)
        {
            await Task.Delay(1000);
            if (klientSomSkickar != null && KHM.Count > 0)
            {
                //Skickar ut meddelandet som är infogad i variabeln "string message" 
                byte[] utData = Encoding.Unicode.GetBytes(message);
                //För varje användare som finns i listan så ska meddelandet skickas till

                for (int i = 0; i < size; i++)
                {
                    try //
                    {   //Om klienten som har valts i listan INTE är en själv/den som skickade

                        if (KHM.ContainsKey(i))
                        {
                            s = KHM[i].GetStream();
                            if (KHM[i] != klientSomSkickar && KHM[i].Connected)
                            {
                                //Väntar tills den får kod och skriver 

                                if (KHM[i].Connected)
                                {
                                    //await s.WriteAsync(utData, 0, utData.Length);
                                    await s.WriteAsync(utData, 0, utData.Length);
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        if (!KHM[i].Connected)
                        {
                            KHM.Remove(i);
                            lblA.Text = KHM.Count.ToString();
                        }
                        continue;

                    }
                }
            }
        }


        //Sätts igång när servern stängs av
        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            lyssnare.Stop();
            if (klient != null && klient.Connected)
            {
                klient.Close();
            }
        }


    }
}
