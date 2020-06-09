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
    public Socket UdpSocket;
    private readonly List<EndPoint> _clientList = new List<EndPoint>();
    private readonly byte[] _byteData = new byte[1024];

    private static readonly ManualResetEvent SendDone = new ManualResetEvent(false);

    public void StartServer(int port)
    {
        UdpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        UdpSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
        UdpSocket.Bind(new IPEndPoint(IPAddress.Any, port));
        EndPoint newClientEp = new IPEndPoint(IPAddress.Any, 0);
        UdpSocket.BeginReceiveFrom(_byteData, 0, _byteData.Length, SocketFlags.None, ref newClientEp, DoReceiveFrom, newClientEp);
    }

    public void StartClient(string address, int port)
    {
        UdpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        UdpSocket.Connect(IPAddress.Parse(address), port);
        EndPoint newClientEp = new IPEndPoint(IPAddress.Any, 0);
        UdpSocket.BeginReceiveFrom(_byteData, 0, _byteData.Length, SocketFlags.None, ref newClientEp, DoReceiveFrom, newClientEp);
    }

    private void DoReceiveFrom(IAsyncResult iar)
    {
        try
        {
            EndPoint clientEp = new IPEndPoint(IPAddress.Any, 0);
            try
            {
                var dataLen = UdpSocket.EndReceiveFrom(iar, ref clientEp);
                var data = new byte[dataLen];
                Array.Copy(_byteData, data, dataLen);

                EndPoint newClientEp = new IPEndPoint(IPAddress.Any, 0);
                UdpSocket.BeginReceiveFrom(_byteData, 0, _byteData.Length, SocketFlags.None, ref newClientEp, DoReceiveFrom, newClientEp);

                if (!_clientList.Any(client => client.Equals(clientEp)))
                    _clientList.Add(clientEp);

                GyroQuaternion gyroQuaternion = JsonConvert.DeserializeObject<GyroQuaternion>(Encoding.ASCII.GetString(data));
                Eventing.eventReceiveUDPServer.InvokeOnNewReceiveUDPServer(gyroQuaternion);
            }
            catch (Exception ex)
            {
                Program.ExceptionLog(ex);
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
        UdpSocket.BeginSend(data, 0, data.Length, 0, SendCallback, UdpSocket);
        SendDone.WaitOne();
    }

    private static void SendCallback(IAsyncResult ar)
    {
        try
        {
            Socket client = (Socket)ar.AsyncState;
            int bytesSent = client.EndSend(ar);
            SendDone.Set();
        }
        catch (Exception ex)
        {
            Program.ExceptionLog(ex);
        }
    }
}