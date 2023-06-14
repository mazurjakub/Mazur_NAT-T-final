using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;

namespace Mazur_NAT_T.Forms
{
    public partial class FormHolePunching : Form
    {
        // Reading config file to get IP and port of the server
        private static string[] configFile = Properties.Resources.config.Split('\n');

        private static readonly IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse(configFile[0].Trim().ToString()), Int32.Parse(configFile[1]));
        private static IPEndPoint clientEndPoint;
        public static UdpClient client = new UdpClient();

        private static bool hasSendKey = false, hasSecondClient = false;
        private static string secondClientIP, secondClientPort;

        private Thread threadListenServer, threadListenClient, threadIsConnected;

        public FormHolePunching()
        {
            InitializeComponent();
            FormClosing += FormHolePunching_Closing;
        }


        private void FormHolePunching_Load(object sender, EventArgs e)
        {
            try
            {
                txtBoxOutput.Text = FormMainMenu.lblHolep;
                txtBoxOutput.Refresh();

                // If this form wasnt loaded before, connect to serverEndPoint via UDP client
                if (!FormMainMenu.alreadyLoaded)
                {
                    FormMainMenu.alreadyLoaded = true;
                    //Setting up UDP socket and connecting to server endpoint
                    client.AllowNatTraversal(true);
                    client.ExclusiveAddressUse = false;
                    client.Client.SetIPProtectionLevel(IPProtectionLevel.Unrestricted);
                    client.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                    client.Client.Connect(serverEndPoint);
                }

                if (!hasSecondClient)
                {
                    //Start recieving data from server
                    threadListenServer = new Thread(() => ReceiveDataFromEP(serverEndPoint))
                    {
                        IsBackground = true
                    };
                    threadListenServer.Start();

                    // Start checking if second client has connected
                    threadIsConnected = new Thread(() => IsClientConnected())
                    {
                        IsBackground = true
                    };
                    threadIsConnected.Start();
                }
                else
                {
                    // If second client is connected, start recieving data from client
                    threadListenClient = new Thread(() => ReceiveDataFromEP(clientEndPoint))
                    {
                        IsBackground = true
                    };
                    threadListenClient.Start();
                }
            }
            catch (Exception ex)
            {
                WriteToTextBox("Chyba při navazování spojení." + ex.Message);
            }
        }

        private void FormHolePunching_Closing(object sender, FormClosingEventArgs e)
        {
            // Closing threads on Form closing
            if (!hasSecondClient)
            {
                threadListenServer.Abort();
                threadIsConnected.Abort();
            }
            else
            {
                threadListenClient.Abort();
            }
        }

        private void ConnectToClient()
        {
            try
            {
                WriteToTextBox("\n");
                WriteToTextBox("Navazuji spojení s klientem");
                // Stop listening to server and connect UDP client to second client EP
                threadListenServer.Abort();
                clientEndPoint = new IPEndPoint(IPAddress.Parse(secondClientIP), int.Parse(secondClientPort));
                client.Client.Connect(clientEndPoint);

                // Start recieving data from client
                threadListenClient = new Thread(() => ReceiveDataFromEP(clientEndPoint))
                {
                    IsBackground = true
                };
                threadListenClient.Start();

                // Send message to second client to "punch a hole" in NAT device
                SendDataToEP("Hello", clientEndPoint);

                WriteToTextBox("\n");
                WriteToTextBox("Spojení bylo navázáno. Nyní můžete odesílat zpávy pomocí peer-to-peer připojení.");

            }
            catch (Exception ex)
            {
                WriteToTextBox("\nNepodařilo se připojit ke klientovi: " + ex.Message);
            }

        }


        //Sends string to given endpoint
        private void SendDataToEP(string dataToSend, IPEndPoint ep)
        {
            try
            {
                if (dataToSend.Length > 0)
                {
                    int byteCount = Encoding.ASCII.GetByteCount(dataToSend);
                    byte[] sendData = Encoding.ASCII.GetBytes(dataToSend);
                    client.Send(sendData, byteCount, ep);
                }
                else
                {
                    MessageBox.Show("Nebyla zadána zádná zpráva k odeslání.");
                }
            }
            catch (Exception ex)
            {
                WriteToTextBox("\nChyba při odesílání dat: " + ex.Message);
            }

        }


        private void ReceiveDataFromEP(IPEndPoint endPoint)
        {
            while (true)
            {
                if (client.Client.Connected)
                {
                    byte[] receivedData;
                    // Waiting for incomming data
                    receivedData = client.Receive(ref endPoint);

                    string request = Encoding.UTF8.GetString(receivedData);

                    WriteToTextBox("\n");
                    WriteToTextBox("Příchozi zpráva z IP: " + endPoint.Address.ToString() + " Port: " + endPoint.Port.ToString());
                    WriteToTextBox("Obsah zprávy: " + request + "\n");

                    // If incomming data contains IP address, initiate connection to that IP
                    if (IsIPAddress(request) && !hasSecondClient)
                    {
                        secondClientIP = request;
                        hasSecondClient = true;

                        // Waiting for port of second client
                        receivedData = client.Receive(ref endPoint);
                        request = Encoding.UTF8.GetString(receivedData);

                        WriteToTextBox("\n");
                        WriteToTextBox("Příchozi zpráva z IP: " + endPoint.Address.ToString() + " Port: " + endPoint.Port.ToString());
                        WriteToTextBox("Obsah zprávy: " + request + "\n");

                        secondClientPort = request;
                    }
                }
                else
                {
                    WriteToTextBox("\nChyba při přijímání dat");
                    return;
                }
            }
        }

        // From https://stackoverflow.com/questions/7461080/fastest-way-to-check-if-string-contains-only-digits-in-c-sharp
        private static bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }



        //From https://morgantechspace.com/2016/01/check-string-is-ip-address-in-c-sharp.html
        private static bool IsIPAddress(string ipAddress)
        {
            bool retVal = false;

            try
            {
                retVal = IPAddress.TryParse(ipAddress, out IPAddress address);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return retVal;
        }

        //This method writes given string to textbox
        private void WriteToTextBox(string str)
        {
            if (txtBoxOutput.InvokeRequired)
            {
                Action writeSafe = delegate { WriteToTextBox($"{str}"); };
                txtBoxOutput.Invoke(writeSafe);
            }
            else
            {
                try
                {
                    txtBoxOutput.AppendText(Environment.NewLine);
                    txtBoxOutput.AppendText(str);
                    txtBoxOutput.Refresh();
                    FormMainMenu.lblHolep = txtBoxOutput.Text;
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            // Checking if given key isnt empty or if it contains only numbers
            if (txtBoxKey.Text == "" || !IsDigitsOnly(txtBoxKey.Text))
            {
                MessageBox.Show("Klíč nesmí být prázdný a musí obsahovat pouze číslice!");
                return;
            }
            // If given key is 0 and client has already sent some key, then send 0 to server to delete previously sent key
            else if(txtBoxKey.Text == "0" && hasSendKey)
            {
                SendDataToEP(txtBoxKey.Text, serverEndPoint);
                txtBoxKey.Text = "";
                txtBoxKey.Refresh();
                hasSendKey = false;
            }
            else if (int.Parse(txtBoxKey.Text) < 1 || int.Parse(txtBoxKey.Text) > 999)
            {
                MessageBox.Show("Klíč může nabývat pouze hodnot 1-999!");
                return;
            }
            else if (FormMainMenu.isFirstMessage)
            {
                FormMainMenu.isFirstMessage = false;
                txtBoxOutput.Text = "Pro vymazání záznamu ze serveru, zadejte klíč '0'.";
                SendDataToEP(txtBoxKey.Text, serverEndPoint);
                txtBoxKey.Text = "";
                txtBoxKey.Refresh();
                hasSendKey = true;
            }
            else
            {
                SendDataToEP(txtBoxKey.Text, serverEndPoint);
                txtBoxKey.Text = "";
                txtBoxKey.Refresh();
                hasSendKey = true;
            }
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            if (!hasSecondClient) MessageBox.Show("Nejste připojen k žádnému klientovi");

            else if(txtBoxMessage.Text != "")
            {
                SendDataToEP(txtBoxMessage.Text, clientEndPoint);
                txtBoxMessage.Text = "";
                txtBoxMessage.Refresh();
            }
            else MessageBox.Show("Zadejte zprávu k odeslání");
        }

        private void IsClientConnected()
        {
            while (true)
            {
                // Checks every two seconds if server sent IP and port of second client
                Thread.Sleep(2000);
                if (hasSecondClient)
                {
                    ConnectToClient();
                    return;
                }
            }
        }
    }
}
