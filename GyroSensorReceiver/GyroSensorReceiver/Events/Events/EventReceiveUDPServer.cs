using System;
using GyroSensorReceiver.Models;

namespace GyroSensorReceiver.Events.Events
{
    public class EventReceiveUdpServer
    {
        public delegate void NewReceiveUdpServer(object sender, NewEventReceiveUdpServerArgs e);
        public event NewReceiveUdpServer OnNewReceiveUdpServer;

        public void InvokeOnNewReceiveUDPServer(GyroQuaternion quaternion)
        {
            NewReceiveUdpServer handler = OnNewReceiveUdpServer;
            NewEventReceiveUdpServerArgs e = new NewEventReceiveUdpServerArgs(quaternion);
            handler?.Invoke(this, e);
        }
    }

    public class NewEventReceiveUdpServerArgs : EventArgs
    {
        public NewEventReceiveUdpServerArgs(GyroQuaternion quaternion) => ReceiveUdpServerMessage = quaternion;
        public GyroQuaternion ReceiveUdpServerMessage { get; }
    }
}