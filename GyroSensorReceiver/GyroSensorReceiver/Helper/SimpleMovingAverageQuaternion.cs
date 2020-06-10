using System.Collections.Generic;
using System.Linq;

namespace FiltfiltApp
{
    public class SimpleMovingAverageQuaternion
    {
        public static GyroQuaternion GetLastValue(List<GyroQuaternion> quatList, int period)
        {
            float[] qX = Calculate(quatList.Select(x => x.qX).ToArray(), period);
            float[] qY = Calculate(quatList.Select(x => x.qY).ToArray(), period);
            float[] qZ = Calculate(quatList.Select(x => x.qZ).ToArray(), period);
            float[] qW = Calculate(quatList.Select(x => x.qW).ToArray(), period);

            if (quatList.Count > 0)
                return new GyroQuaternion(quatList[0].sensorName, qX.Last(), qY.Last(), qZ.Last(), qW.Last());

            return null;
        }

        public static float[] Calculate(float[] price, int period)
        {
            if (price.Length <= period)
                return price;

            var sma = new float[price.Length];

            float sum = 0;

            for (int i = 0; i < period; i++)
            {
                sum += price[i];
                sma[i] = sum / (i + 1);
            }

            for (int i = period; i < price.Length; i++)
            {
                sum = 0;
                for (int j = i; j > i - period; j--)
                {
                    sum += price[j];
                }
                sma[i] = sum / period;
            }
            return sma;
        }
    }
}