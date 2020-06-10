using FiltfiltApp;

public class FilterQuaternion
{
    readonly KalmanFilter _kalmanFilterX;
    readonly KalmanFilter _kalmanFilterY;
    readonly KalmanFilter _kalmanFilterZ;
    readonly KalmanFilter _kalmanFilterW;

    readonly FixedSizedQueue<GyroQuaternion> _quaternionQueue;
    private readonly int _period = 5;

    public FilterQuaternion(float processNoise = 1, float measurementNoise = 1, int period = 5, int queueCount = 15)
    {
        _period = period;

        _quaternionQueue = new FixedSizedQueue<GyroQuaternion>(queueCount);

        _kalmanFilterX = new KalmanFilter(processNoise, measurementNoise);
        _kalmanFilterY = new KalmanFilter(processNoise, measurementNoise);
        _kalmanFilterZ = new KalmanFilter(processNoise, measurementNoise);
        _kalmanFilterW = new KalmanFilter(processNoise, measurementNoise);
    }

    public GyroQuaternion Filter(GyroQuaternion gyroQuaternion)
    {
        _quaternionQueue.Enqueue(gyroQuaternion);

        GyroQuaternion smaValue = SimpleMovingAverageQuaternion.GetLastValue(_quaternionQueue.GetAllItems(), _period);

        float qX = _kalmanFilterX.Filter(smaValue.qX);
        float qY = _kalmanFilterY.Filter(smaValue.qY);
        float qZ = _kalmanFilterZ.Filter(smaValue.qZ);
        float qW = _kalmanFilterW.Filter(smaValue.qW);

        GyroQuaternion result = new GyroQuaternion(gyroQuaternion.sensorName, qX, qY, qZ, qW);

        return result;
    }
}