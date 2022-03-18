using System;
using GyroSensorReceiver.Utils;

namespace GyroSensorReceiver.Models
{
    public class GyroQuaternion
    {
        public string type = "gyroData";
        public string sensorName { get; set; }
        public float qX { get; set; }
        public float qY { get; set; }
        public float qZ { get; set; }
        public float qW { get; set; }

        public GyroQuaternion(string SensorName, float X, float Y, float Z, float W)
        {
            sensorName = SensorName;
            qX = X;
            qY = Y;
            qZ = Z;
            qW = W;
        }

        public static GyroQuaternion Inverse(GyroQuaternion quat)
        {
            GyroQuaternion quaternion2 = new GyroQuaternion(quat.sensorName, 0, 0, 0, -1);
            float num2 = quat.qX * quat.qX + quat.qY * quat.qY + quat.qZ * quat.qZ + quat.qW * quat.qW;
            float num = 1f / num2;

            quaternion2.qX = -quat.qX * num;
            quaternion2.qY = -quat.qY * num;
            quaternion2.qZ = -quat.qZ * num;
            quaternion2.qW = quat.qW * num;

            return quaternion2;
        }

        public static GyroQuaternion Multiply(GyroQuaternion q1, GyroQuaternion q2)
        {
            float qX = q1.qW * q2.qX + q1.qX * q2.qW + q1.qY * q2.qZ - q1.qZ * q2.qY;
            float qY = q1.qW * q2.qY + q1.qY * q2.qW + q1.qZ * q2.qX - q1.qX * q2.qZ;
            float qZ = q1.qW * q2.qZ + q1.qZ * q2.qW + q1.qX * q2.qY - q1.qY * q2.qX;
            float qW = q1.qW * q2.qW - q1.qX * q2.qX - q1.qY * q2.qY - q1.qZ * q2.qZ;

            return new GyroQuaternion(q1.sensorName, qX, qY, qZ, qW);
        }

        public static Point3D QuaternionToEuler(GyroQuaternion quaternion)
        {
            Point3D point3D = new Point3D();

            float singularityTest = quaternion.qZ * quaternion.qX - quaternion.qW * quaternion.qY;
            float yawY = 2f * (quaternion.qW * quaternion.qZ + quaternion.qX * quaternion.qY);
            float yawX = 1f - 2f * (quaternion.qY * quaternion.qY + quaternion.qZ * quaternion.qZ);

            const float radToDeg = (float)(180 / Math.PI);

            if (singularityTest < -0.4999995f)
            {
                point3D.X = -90f;
                point3D.Y = (float)Math.Atan2(yawY, yawX) * radToDeg;
                point3D.Z = NormalizeAxis((float)(-point3D.Y - 2f * Math.Atan2(quaternion.qX, quaternion.qW) * radToDeg));
            }
            else if (singularityTest > 0.4999995f)
            {
                point3D.X = 90f;
                point3D.Y = (float)Math.Atan2(yawY, yawX) * radToDeg;
                point3D.Z = NormalizeAxis((float)(point3D.Y - 2f * Math.Atan2(quaternion.qX, quaternion.qW) * radToDeg));
            }
            else
            {
                point3D.X = (float)Math.Asin(2f * singularityTest) * radToDeg;
                point3D.Y = (float)Math.Atan2(yawY, yawX) * radToDeg;
                point3D.Z = (float)Math.Atan2(-2f * (quaternion.qW * quaternion.qX + quaternion.qY * quaternion.qZ), 1f - 2f * (quaternion.qX * quaternion.qX + quaternion.qY * quaternion.qY)) * radToDeg;
            }

            return point3D;
        }

        private static float NormalizeAxis(float angle)
        {
            angle = FMod(angle, 360);

            if (angle < 0f)
                angle += 360f;

            if (angle > 180f)
                angle -= 360f;

            return angle;
        }

        private static float FMod(float x, float y)
        {
            if (Math.Abs(y) <= 1E-8f)
                return 0;

            float quotient = (int)(x / y);
            float intPortion = y * quotient;

            if (Math.Abs(intPortion) > Math.Abs(x))
                intPortion = x;

            float result = x - intPortion;

            return result;
        }
    }
}