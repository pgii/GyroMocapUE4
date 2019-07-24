void SerialPortReceive()
{
    String receivedString;
  
    while(Serial.available())
    {
        receivedString = Serial.readString();
    }

    if (receivedString.length() > 0) 
    {
        SerialPortParseReceived(receivedString);
        receivedString = "";
    }
}

void SerialPortSend(String sendStr)
{
    Serial.println(sendStr);
}

void SerialPortParseReceived(String receivedString)
{
    char charBuf[1024];
    receivedString.toCharArray(charBuf, 1024);
    StaticJsonDocument<1024> jsonDoc;
    DeserializationError error = deserializeJson(jsonDoc, charBuf);
    if (error) 
    {
        Serial.print(receivedString);
        Serial.print(F("deserializeJson() failed: "));
        Serial.println(error.c_str());
        return;
    }

    const char * jsonType = jsonDoc["type"];

    if (String(jsonType) == "loadSettings")
    {
        String loadSettingsJSONString = LoadSettingsJSONString();
        Serial.println(loadSettingsJSONString);
    }

    if (String(jsonType) == "saveSettings")
    {
        const char * wifi_ssid = jsonDoc["wifi_ssid"];
        const char * wifi_pass = jsonDoc["wifi_pass"];
        const char * sensor_name = jsonDoc["sensor_name"];
        const char * sensor_id = jsonDoc["sensor_id"];
        const char * mocap_server = jsonDoc["mocap_server"];
        const char * mocap_server_port = jsonDoc["mocap_server_port"];
        
        String saveSettingsJSONStringResult = SaveSettingsFromJsonDocument(String(wifi_ssid), String(wifi_pass), String(sensor_name), String(mocap_server), String(mocap_server_port));

        Serial.println(saveSettingsJSONStringResult);

        InitWiFi();
    }
    
    if (String(jsonType) == "resetSettings")
    {
        String resetSettingsJSONStringResult = ResetSettingsJSONString();
        Serial.println(resetSettingsJSONStringResult);

        InitWiFi();
    }

    if (String(jsonType) == "getStatus")
    {
        int wifiStatus = WiFi.status() == WL_CONNECTED ? 1 : 0;
        String localIP = IPToString(WiFi.localIP());
        
        String getStatusJSONStringResult = GetStatusJSONString(wifiStatus, localIP);
        Serial.println(getStatusJSONStringResult);
    }
}
