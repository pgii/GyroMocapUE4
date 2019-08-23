using System;
public class EventReceiveUDPServer
{
    public delegate void NewReceiveUDPServer(object sender, NewEventReceiveUDPServerArgs e);
    public event NewReceiveUDPServer OnNewReceiveUDPServer;

    public void InvokeOnNewReceiveUDPServer(GyroQuaternion quat)
    {
        NewReceiveUDPServer handler = OnNewReceiveUDPServer;
        NewEventReceiveUDPServerArgs e = new NewEventReceiveUDPServerArgs(quat);
        handler?.Invoke(this, e);
    }
}

public class NewEventReceiveUDPServerArgs : EventArgs
{
    public NewEventReceiveUDPServerArgs(GyroQuaternion quat)
    {
        ReceiveUDPServerMessage = quat;
    }
    public GyroQuaternion ReceiveUDPServerMessage { get; }
}