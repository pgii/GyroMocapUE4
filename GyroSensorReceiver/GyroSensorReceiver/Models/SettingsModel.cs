using GyroSensorReceiver.Models;

class SettingsModel : BaseModel
{
    public string wifi_ssid;
    public string wifi_pass;
    public string sensor_name;
    public string sensor_id;
    public string mocap_server;
    public string mocap_server_port;
}

class SaveSettingsResultModel : BaseModel
{
    public int error;
}

class ResetSettingsResultModel : BaseModel
{
    public int error;
}