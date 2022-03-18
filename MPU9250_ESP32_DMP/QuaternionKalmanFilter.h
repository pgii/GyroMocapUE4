#include "I2Cdev.h"
#include "helper_3dmath.h"
#include "math.h"

class QuaternionKalmanFilter {
private:
	float gain;
	int memory;
	Quaternion* values;

	int currentAmount = 0;

	Quaternion* ShiftArray(Quaternion arr[]);

public:
	QuaternionKalmanFilter();
	QuaternionKalmanFilter(float gain, int memory);

	Quaternion Filter(Quaternion input);

};
