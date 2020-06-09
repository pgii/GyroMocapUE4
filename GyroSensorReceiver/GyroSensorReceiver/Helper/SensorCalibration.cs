using System.Collections.Concurrent;
using System.Linq;

public class SensorCalibration
{
    readonly ConcurrentDictionary<string, GyroQuaternion> _calibrationDictionary = new ConcurrentDictionary<string, GyroQuaternion>();

    public void Push(GyroQuaternion quat)
    {
        if (_calibrationDictionary.All(x => x.Key != quat.sensorName))
            _calibrationDictionary.TryAdd(quat.sensorName, new GyroQuaternion(quat.sensorName, quat.qX, quat.qY, quat.qZ, quat.qW));
    }

    public GyroQuaternion GetCalibrationResult(string sensorName)
    {
        return _calibrationDictionary.FirstOrDefault(x => x.Key == sensorName).Value;
    }
}

