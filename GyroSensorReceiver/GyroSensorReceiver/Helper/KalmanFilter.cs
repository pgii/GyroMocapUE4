public class KalmanFilter
{
    private readonly float _processNoise;
    private readonly float _measurementNoise;
    private readonly float _stateVector = 1.0f;
    private readonly float _controlVector = 0.0f;
    private readonly float _measurementVector = 1.0f;
    private float _covariance = float.NaN;
    private float _filteredMeasurementValue = float.NaN;

    public KalmanFilter(float processNoise = 1, float measurementNoise = 1)
    {
        _processNoise = processNoise;
        _measurementNoise = measurementNoise;
    }

    public float Filter(float z)
    {
        return Filter(z, 0.0f);
    }

    private float Filter(float measurement, float controlValue)
    {
        if (float.IsNaN(_filteredMeasurementValue))
        {
            _filteredMeasurementValue = 1 / _measurementVector * measurement;
            _covariance = 1 / _measurementVector * _measurementNoise * (1 / _measurementVector);
        }
        else
        {
            float predictionX = _stateVector * _filteredMeasurementValue + _controlVector * controlValue;
            float predictionCovariance = _stateVector * _covariance * _stateVector + _processNoise;
            float kalmanGain = predictionCovariance * _measurementVector * (1 / (_measurementVector * predictionCovariance * _measurementVector + _measurementNoise));
            _filteredMeasurementValue = predictionX + kalmanGain * (measurement - _measurementVector * predictionX);
            _covariance = predictionCovariance - kalmanGain * _measurementVector * predictionCovariance;
        }
        return _filteredMeasurementValue;
    }

}