AsyncUDP udpClient;

void UDPConnect()
{
    String mocapServer = ReadStringEEPROM(3);
    String mocapServerPort = ReadStringEEPROM(4);

    IPAddress ipAddress = IPAddress();
    ipAddress.fromString(mocapServer);

    int port = mocapServerPort.toInt();
    
    udpClient.connect(ipAddress, port);   
}

void UDPSendData(String message)
{
    String mocapServerPort = ReadStringEEPROM(4);
    int port = mocapServerPort.toInt();

    char charBuffer[1024];
    message.toCharArray(charBuffer, 1024);

    if (udpClient.connected())
        udpClient.broadcastTo(charBuffer, port);
    else
        UDPConnect();
}
