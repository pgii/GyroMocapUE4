void InitSettings()
{
    if (CheckIsEmptyEEPROM(0)) WriteStringEEPROM(0, "wifi_ssid");
    if (CheckIsEmptyEEPROM(1)) WriteStringEEPROM(1, "wifi_pass");
    if (CheckIsEmptyEEPROM(2)) WriteStringEEPROM(2, "GyroSensor00");
    if (CheckIsEmptyEEPROM(3)) WriteStringEEPROM(3, "127.0.0.1");
    if (CheckIsEmptyEEPROM(4)) WriteStringEEPROM(4, "7755");
}

String ResetSettingsJSONString() 
{
    WriteStringEEPROM(0, "wifi_ssid");
    WriteStringEEPROM(1, "wifi_pass");
    WriteStringEEPROM(2, "GyroSensor00");
    WriteStringEEPROM(3, "127.0.0.1");
    WriteStringEEPROM(4, "7755");

    delay(100);
    
    StaticJsonDocument<1024> staticJsonDocument;
    char docBuf[1024];
    staticJsonDocument["type"] = "resetSettingsResult";
    staticJsonDocument["error"] = 0;

    serializeJson(staticJsonDocument, docBuf);

    return String(docBuf);
}

String LoadSettingsJSONString() 
{
    StaticJsonDocument<1024> staticJsonDocument;
    staticJsonDocument["type"] = "loadSettingsResult";
    staticJsonDocument["wifi_ssid"] = ReadStringEEPROM(0);
    staticJsonDocument["wifi_pass"] = ReadStringEEPROM(1);
    staticJsonDocument["sensor_name"] = ReadStringEEPROM(2);
    staticJsonDocument["mocap_server"] = ReadStringEEPROM(3);
    staticJsonDocument["mocap_server_port"] = ReadStringEEPROM(4);

    delay(100);
    
    char docBuf[1024];
    serializeJson(staticJsonDocument, docBuf);

    return String(docBuf);
}

String SaveSettingsFromJsonDocument(String wifi_ssid, String wifi_pass, String sensor_name, String mocap_server, String mocap_server_port) 
{
    WriteStringEEPROM(0, wifi_ssid);
    WriteStringEEPROM(1, wifi_pass);
    WriteStringEEPROM(2, sensor_name);
    WriteStringEEPROM(3, mocap_server);
    WriteStringEEPROM(4, mocap_server_port);

    delay(100);
    
    StaticJsonDocument<1024> staticJsonDocument;
    char docBuf[1024];
    staticJsonDocument["type"] = "saveSettingsResult";
    staticJsonDocument["error"] = 0;

    serializeJson(staticJsonDocument, docBuf);

    return String(docBuf);
}
