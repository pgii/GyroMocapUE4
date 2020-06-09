public class KalmanFilterQuaternion
{
    KalmanFilter _kalmanFilterX;
    KalmanFilter _kalmanFilterY;
    KalmanFilter _kalmanFilterZ;
    KalmanFilter _kalmanFilterW;

    private readonly float _processNoise;
    private readonly float _measurementNoise;
    private readonly float _stateVector = 1.0f;
    private readonly float _controlVector = 0.0f;
    private readonly float _measurementVector = 1.0f;
    private float _covariance = float.NaN;
    private float _filteredMeasurementValue = float.NaN;

    public KalmanFilterQuaternion(float processNoise = 1, float measurementNoise = 1)
    {
        _processNoise = processNoise;
        _measurementNoise = measurementNoise;

        _kalmanFilterX = new KalmanFilter(processNoise, measurementNoise);
        _kalmanFilterY = new KalmanFilter(processNoise, measurementNoise);
        _kalmanFilterZ = new KalmanFilter(processNoise, measurementNoise);
        _kalmanFilterW = new KalmanFilter(processNoise, measurementNoise);
    }

    public GyroQuaternion Filter(GyroQuaternion gyroQuaternion)
    {

        float qX = _kalmanFilterX.Filter(gyroQuaternion.qX);
        float qY = _kalmanFilterY.Filter(gyroQuaternion.qY);
        float qZ = _kalmanFilterZ.Filter(gyroQuaternion.qZ);
        float qW = _kalmanFilterW.Filter(gyroQuaternion.qW);

        return new GyroQuaternion(gyroQuaternion.sensorName, qX, qY, qZ, qW);
    }
}