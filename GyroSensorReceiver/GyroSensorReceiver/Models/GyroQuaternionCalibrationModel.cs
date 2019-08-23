public class GyroQuaternionCalibrationModel
{
    public GyroQuaternion GyroQuaternion { get; set; }
    public int CalibrationCount { get; set; }
    public bool CalibrationComplete { get; set; }

    public GyroQuaternionCalibrationModel(GyroQuaternion gyroQuaternion)
    {
        GyroQuaternion = gyroQuaternion;
    }
}

