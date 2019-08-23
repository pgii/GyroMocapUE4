using System.Collections.Concurrent;
using System.Linq;

public class SensorCalibration
{
    ConcurrentDictionary<string, GyroQuaternion> calibrationDictionary = new ConcurrentDictionary<string, GyroQuaternion>();

    public SensorCalibration()
    {
    }

    public void Push(GyroQuaternion quat)
    {
        if (!calibrationDictionary.Any(x => x.Key == quat.sensorName))
            calibrationDictionary.TryAdd(quat.sensorName, new GyroQuaternion(quat.sensorName, quat.qX, quat.qY, quat.qZ, quat.qW));
    }

    public GyroQuaternion GetCalibrationResult(string sensorName)
    {
        return calibrationDictionary.FirstOrDefault(x => x.Key == sensorName).Value;
    }
}

