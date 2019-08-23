using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

public class UDPAsyncSocket
{
    public Socket udpSocket = null;
    private List<EndPoint> clientList = new List<EndPoint>();
    private byte[] byteData = new byte[1024];

    private static ManualResetEvent sendDone = new ManualResetEvent(false);

    public UDPAsyncSocket() { }

    public void StartServer(int port)
    {
        udpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        udpSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
        udpSocket.Bind(new IPEndPoint(IPAddress.Any, port));
        EndPoint newClientEP = new IPEndPoint(IPAddress.Any, 0);
        udpSocket.BeginReceiveFrom(byteData, 0, byteData.Length, SocketFlags.None, ref newClientEP, DoReceiveFrom, newClientEP);
    }

    public void StartClient(string address, int port)
    {
        udpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        udpSocket.Connect(IPAddress.Parse(address), port);
        EndPoint newClientEP = new IPEndPoint(IPAddress.Any, 0);
        udpSocket.BeginReceiveFrom(byteData, 0, byteData.Length, SocketFlags.None, ref newClientEP, DoReceiveFrom, newClientEP);
    }

    private void DoReceiveFrom(IAsyncResult iar)
    {
        try
        {
            EndPoint clientEP = new IPEndPoint(IPAddress.Any, 0);
            int dataLen = 0;
            byte[] data = null;
            try
            {
                dataLen = udpSocket.EndReceiveFrom(iar, ref clientEP);
                data = new byte[dataLen];
                Array.Copy(byteData, data, dataLen);

                EndPoint newClientEP = new IPEndPoint(IPAddress.Any, 0);
                udpSocket.BeginReceiveFrom(byteData, 0, byteData.Length, SocketFlags.None, ref newClientEP, DoReceiveFrom, newClientEP);

                if (!clientList.Any(client => client.Equals(clientEP)))
                    clientList.Add(clientEP);

                GyroQuaternion gyroQuaternion = JsonConvert.DeserializeObject<GyroQuaternion>(Encoding.ASCII.GetString(data));
                Eventing.eventReceiveUDPServer.InvokeOnNewReceiveUDPServer(gyroQuaternion);
            }
            catch (Exception ex)
            {
                Program.ExceptionLog(ex);
            }
            finally
            {

            }

        }
        catch (ObjectDisposedException dex)
        {
            Program.ExceptionLog(dex);
        }
    }

    public void Send(GyroQuaternion gyroQuaternion)
    {
        byte[] data = Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(gyroQuaternion));
        udpSocket.BeginSend(data, 0, data.Length, 0, new AsyncCallback(SendCallback), udpSocket);
        sendDone.WaitOne();
    }

    private static void SendCallback(IAsyncResult ar)
    {
        try
        {
            Socket client = (Socket)ar.AsyncState;
            int bytesSent = client.EndSend(ar);
            sendDone.Set();
        }
        catch (Exception ex)
        {
            Program.ExceptionLog(ex);
        }
    }

    public void Stop()
    {
        udpSocket.Close();
        udpSocket = null;
        clientList.Clear();
    }
}