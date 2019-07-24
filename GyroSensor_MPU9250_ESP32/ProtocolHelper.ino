#include "ArduinoJson.h"

String GetStatusJSONString(int wifiStatus, String localIP) 
{
    StaticJsonDocument<1024> staticJsonDocument;
    staticJsonDocument["type"] = "getStatusResult";
    staticJsonDocument["wifi_status"] = wifiStatus;
    staticJsonDocument["local_ip"] = localIP;
 
    char docBuf[1024];
    serializeJson(staticJsonDocument, docBuf);

    return String(docBuf);
}

String GetGyroDataJSONString(String sensorName, float qX, float qY, float qZ, float qW) 
{
    StaticJsonDocument<1024> staticJsonDocument;
    staticJsonDocument["type"] = "gyroData";
    staticJsonDocument["sensorName"] = sensorName;
    staticJsonDocument["qX"] = String(qX, 2);
    staticJsonDocument["qY"] = String(qY, 2);
    staticJsonDocument["qZ"] = String(qZ, 2);
    staticJsonDocument["qW"] = String(qW, 2);
    
    char docBuf[1024];
    serializeJson(staticJsonDocument, docBuf);

    return String(docBuf);
}
