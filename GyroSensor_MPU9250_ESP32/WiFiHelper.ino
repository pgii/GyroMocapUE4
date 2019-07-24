void InitWiFi()
{
    String ssidStr = ReadStringEEPROM(0);
    const char *ssid = ssidStr.c_str();
    String passStr = ReadStringEEPROM(1);
    const char *pass = passStr.c_str();

    WiFi.begin(ssid, pass);

    for(int i = 0; i < 5; i++)
    {
        if (WiFi.status() == WL_CONNECTED)
            break;
        delay(1000);
    }
}
