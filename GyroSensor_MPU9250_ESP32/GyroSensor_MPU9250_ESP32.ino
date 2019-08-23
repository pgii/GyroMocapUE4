#include <Wire.h>
#include "I2Cdev.h"
#include "MPU9250_9Axis.h"
#include "EEPROM.h"
#include <WiFi.h>
#include "AsyncUDP.h"

#define EEPROMUtils
#define SettingsUtils
#define SerialPortHelper
#define WiFiHelper
#define UDPClient
#define ProtocolHelper
#define DataUtils

MPU9250 mpu(0x68);

uint8_t mpuIntStatus;
uint16_t packetSize;
uint16_t fifoCount;
uint8_t fifoBuffer[64];
volatile bool mpuInterrupt = false;

Quaternion q;

unsigned long timing;
unsigned long gyroDataIntervalSend = 50;

void setup() 
{
    Serial.begin(115200);
    EEPROM.begin(500);

    InitSettings();
    InitWiFi();
    UDPConnect();
    
    Wire.begin();
    Wire.setClock(400000);
    
    mpu.initialize();

    delay(1000);

    uint8_t devStatus = mpu.dmpInitialize();

    if (devStatus == 0) 
    {
        mpu.setDMPEnabled(true);
        mpuIntStatus = mpu.getIntStatus();
        packetSize = mpu.dmpGetFIFOPacketSize();
    }
}

void loop() 
{
    mpuInterrupt = false;

    mpuIntStatus = mpu.getIntStatus();

    fifoCount = mpu.getFIFOCount();

    if ((mpuIntStatus & 0x10) || fifoCount == 1024) 
    {
        mpu.resetFIFO();
    } 
    else if (mpuIntStatus & 0x02) 
    {
        while (fifoCount < packetSize) 
            fifoCount = mpu.getFIFOCount();

        mpu.getFIFOBytes(fifoBuffer, packetSize);

        fifoCount -= packetSize;

        mpu.dmpGetQuaternion(&q, fifoBuffer);

        if (millis() - timing > gyroDataIntervalSend)
        {
            timing = millis();
            String sensorName = ReadStringEEPROM(2);
            String gyroDataJSONString = GetGyroDataJSONString(sensorName, q.x, q.y, q.z, q.w);
            UDPSendData(gyroDataJSONString);
        }
    }

    SerialPortReceive();
}

void dmpDataReady() 
{
    mpuInterrupt = true;
}
