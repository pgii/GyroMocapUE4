using Newtonsoft.Json;
using System;

class ProtocolHelper
{
    public static BaseModel ParseBaseModel(string jsonString)
    {
        BaseModel model = new BaseModel();

        try
        {
            return JsonConvert.DeserializeObject<BaseModel>(jsonString);
        }
        catch (Exception ex)
        {
            Program.ExceptionLog(ex);
        }

        return model;
    }

    public static SettingsModel ParseSettingsModel(string jsonString)
    {
        SettingsModel model = new SettingsModel();

        try
        {
            return JsonConvert.DeserializeObject<SettingsModel>(jsonString);
        }
        catch (Exception ex)
        {
            Program.ExceptionLog(ex);
        }

        return model;
    }

    public static SaveSettingsResultModel ParseSaveSettingsResultModel(string jsonString)
    {
        SaveSettingsResultModel model = new SaveSettingsResultModel();

        try
        {
            return JsonConvert.DeserializeObject<SaveSettingsResultModel>(jsonString);
        }
        catch (Exception ex)
        {
            Program.ExceptionLog(ex);
        }

        return model;
    }

    public static ResetSettingsResultModel ParseResetSettingsResultModel(string jsonString)
    {
        ResetSettingsResultModel model = new ResetSettingsResultModel();

        try
        {
            return JsonConvert.DeserializeObject<ResetSettingsResultModel>(jsonString);
        }
        catch (Exception ex)
        {
            Program.ExceptionLog(ex);
        }

        return model;
    }

    public static StatusModel ParseStatusModel(string jsonString)
    {
        StatusModel model = new StatusModel();

        try
        {
            return JsonConvert.DeserializeObject<StatusModel>(jsonString);
        }
        catch (Exception ex)
        {
            Program.ExceptionLog(ex);
        }

        return model;
    }

    public static GyroDataModel ParseGyroDataModel(string jsonString)
    {
        GyroDataModel model = new GyroDataModel();

        try
        {
            return JsonConvert.DeserializeObject<GyroDataModel>(jsonString);
        }
        catch (Exception ex)
        {
            Program.ExceptionLog(ex);
        }

        return model;
    }
}