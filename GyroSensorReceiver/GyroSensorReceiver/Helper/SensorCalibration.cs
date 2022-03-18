using System.Collections.Concurrent;
using System.Linq;
using GyroSensorReceiver.Models;

namespace GyroSensorReceiver.Helper
{
    public class SensorCalibration
    {
        readonly ConcurrentDictionary<string, GyroQuaternion> _calibrationDictionary = new ConcurrentDictionary<string, GyroQuaternion>();

        public void Push(GyroQuaternion quaternion)
        {
            if (_calibrationDictionary.All(x => x.Key != quaternion.sensorName))
                _calibrationDictionary.TryAdd(quaternion.sensorName, new GyroQuaternion(quaternion.sensorName, quaternion.qX, quaternion.qY, quaternion.qZ, quaternion.qW));
        }

        public GyroQuaternion GetCalibrationResult(string sensorName)
        {
            return _calibrationDictionary.FirstOrDefault(x => x.Key == sensorName).Value;
        }
    }
}