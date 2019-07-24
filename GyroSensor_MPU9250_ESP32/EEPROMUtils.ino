#define EEPROM_SIZE 24

String ReadStringEEPROM(char slot) 
{ 
    int i;
    char data[EEPROM_SIZE];
    int length = 0;
    unsigned char k;
    k = EEPROM.read(EEPROM_SIZE * slot);
    while(k != '\0' && length < EEPROM_SIZE)
    {    
        k = EEPROM.read(EEPROM_SIZE * slot + length);
        data[length] = k;
        length++;
    }
    data[length] = '\0';
    return String(data);
}

bool CheckIsEmptyEEPROM(char slot) 
{ 
    bool isEmpty = true;
    for (int i = EEPROM_SIZE * slot; i < EEPROM_SIZE * slot + EEPROM_SIZE; i++) 
    {
        unsigned char val = EEPROM.read(i);
        if (val != 255)
        {
            isEmpty = false;
            break;
        }
    }
    return isEmpty;
}

void WriteStringEEPROM(char slot, String data)
{
    int dataLength = data.length();
    for(int i = 0; i < dataLength; i++)
        EEPROM.write(EEPROM_SIZE * slot + i, data[i]);  
    EEPROM.write(EEPROM_SIZE * slot + dataLength, '\0');
    EEPROM.commit();
    delay(50);
}

void EraseSlotEEPROM(char slot)
{
    for (int i = EEPROM_SIZE * slot; i < EEPROM_SIZE * slot + EEPROM_SIZE; i++) 
      EEPROM.write(EEPROM_SIZE * slot + i, 255);
    EEPROM.commit();
    delay(50);
}

void EraseEEPROM()
{
    for (int i = 0; i < 500; i++) 
      EEPROM.write(i, 255);
    EEPROM.commit();
    delay(50);
}
