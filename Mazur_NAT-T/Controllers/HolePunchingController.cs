using Mazur_NAT_T.Models;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading;

namespace Mazur_NAT_T.Controllers
{
    public class HolePunchingController
    {
        private static IHolePunchingView _view;
        private static UdpClient udpClient = new UdpClient();
        private static string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\config.txt");
        private static string[] configFile = File.ReadAllLines(path);
        private Client server, client;
        private bool hasSecondClient = false, hasSendKey = false, isFirstMessage = true;
        private Thread threadListenServer, threadListenClient, threadIsConnected;

        public HolePunchingController(IHolePunchingView view)
        {
            _view = view;
            view.SetController(this);
        }

        
        public void Init()
        {
            try
            {
                // Setting up UdpClient to connect to server
                server = new Client(configFile[0].Trim().ToString(), configFile[1]);
                udpClient.ExclusiveAddressUse = false;
                udpClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                udpClient.Client.Connect(server.ClientEP);


                if (!hasSecondClient)
                {
                    //Start recieving data from server
                    threadListenServer = new Thread(() => ReceiveDataFromEP(server.ClientEP))
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
                    threadListenClient = new Thread(() => ReceiveDataFromEP(client.ClientEP))
                    {
                        IsBackground = true
                    };
                    threadListenClient.Start();
                }
            }
            catch(Exception e)
            {
                _view.ShowMessageBox("Nelze se připojit k serveru: " + e.Message);
            }
        }

        public void SendKeyToServer(string key)
        {
            // Checking if given key isnt empty or if it contains only numbers
            if (key == "" || !IsDigitsOnly(key))
            {
                _view.ShowMessageBox("Klíč nesmí být prázdný a musí obsahovat pouze číslice!");
                return;
            }
            // If given key is 0 and client has already sent some key, then send 0 to server to delete previously sent key
            else if (key == "0" && hasSendKey)
            {
                SendDataToEP(key, server.ClientEP);
                hasSendKey = false;
            }
            else if (int.Parse(key) < 1 || int.Parse(key) > 999)
            {
                _view.ShowMessageBox("Registrační klíč může nabývat pouze hodnot 1-999!");
                return;
            }
            else if (isFirstMessage)
            {
                isFirstMessage = false;
                _view.ClearTextBox();
                _view.WriteToTextBox("Pro vymazání záznamu ze serveru, zadejte speciální klíč '0'.");
                SendDataToEP(key, server.ClientEP);
                hasSendKey = true;
            }
            else
            {
                SendDataToEP(key, server.ClientEP);
                hasSendKey = true;
            }
        }

        public void SendMessageToClient(string message)
        {
            if (!hasSecondClient) _view.ShowMessageBox("Nejste připojen k žádnému klientovi");
            else if (message != "") SendDataToEP(message, client.ClientEP);
            else _view.ShowMessageBox("Zadejte zprávu k odeslání.");    
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
                    udpClient.Send(sendData, byteCount, ep);
                }
                else
                {
                    _view.ShowMessageBox("Nebyla zadána zádná zpráva k odeslání.");
                }
            }
            catch (Exception ex)
            {
                _view.WriteToTextBox("\nChyba při odesílání dat: " + ex.Message);
            }

        }

        private void ReceiveDataFromEP(IPEndPoint endPoint)
        {
            string ipAddr;
            while (true)
            {
                if (udpClient.Client.Connected)
                {
                    byte[] receivedData;
                    // Waiting for incomming data
                    receivedData = udpClient.Receive(ref endPoint);

                    string request = Encoding.UTF8.GetString(receivedData);

                    _view.WriteToTextBox("\n");
                    _view.WriteToTextBox("Příchozi zpráva z IP: " + endPoint.Address.ToString() + " Port: " + endPoint.Port.ToString());
                    _view.WriteToTextBox("Obsah zprávy: " + request);

                    // If incomming data contains IP address, initiate connection to that IP
                    if (IsIPAddress(request) && !hasSecondClient)
                    {
                        ipAddr = request;
                        hasSecondClient = true;

                        // Waiting for port of second client
                        receivedData = udpClient.Receive(ref endPoint);
                        request = Encoding.UTF8.GetString(receivedData);

                        client = new Client(ipAddr, request);
                        _view.WriteToTextBox("\n");
                        _view.WriteToTextBox("Příchozi zpráva z IP: " + endPoint.Address.ToString() + " Port: " + endPoint.Port.ToString());
                        _view.WriteToTextBox("Obsah zprávy: " + request);
                        
                    }
                }
                else
                {
                    _view.WriteToTextBox("\nChyba při přijímání dat");
                    return;
                }
            }
        }
        private void ConnectToClient()
        {
            try
            {
                _view.WriteToTextBox("\nObdrženy údaje ze serveru.");

                // Stop listening to server and connect UDP client to second client EP
                _view.WriteToTextBox("Ukončuji spojení se serverem.");
                threadListenServer.Abort();
                _view.WriteToTextBox("Zahajuji spojení s druhým klientem.");
                udpClient.Client.Connect(client.ClientEP);

                // Start recieving data from client
                threadListenClient = new Thread(() => ReceiveDataFromEP(client.ClientEP))
                {
                    IsBackground = true
                };
                threadListenClient.Start();

                // Send message to second client to "punch a hole" in NAT device
                SendDataToEP("Hello", client.ClientEP);
                SendDataToEP("Hello", client.ClientEP);

                _view.WriteToTextBox("\n");
                _view.WriteToTextBox("Spojení bylo navázáno. Nyní můžete odesílat zpávy pomocí peer-to-peer připojení.");

            }
            catch (Exception ex)
            {
                _view.WriteToTextBox("\nNepodařilo se připojit ke klientovi: " + ex.Message);
            }

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
        // Closing threads and udpclient
        public void EndCommunication()
        {
            try
            {
                if (!hasSecondClient)
                {
                    threadListenServer.Abort();
                }
                else
                {
                    threadListenClient.Abort();
                }
                udpClient.Client.Close();
                udpClient.Close();
            }
            catch(Exception e)
            {
                
            }
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
                _view.ShowMessageBox(ex.Message);
            }
            return retVal;
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
        
    }
}
