#ifndef _HELPER_3DMATH_H_
#define _HELPER_3DMATH_H_

class Quaternion {
    public:
        float w;
        float x;
        float y;
        float z;
        
        Quaternion() 
        {
            w = 1.0f;
            x = 0.0f;
            y = 0.0f;
            z = 0.0f;
        }
        
        Quaternion(float nw, float nx, float ny, float nz) 
        {
            w = nw;
            x = nx;
            y = ny;
            z = nz;
        }

        Quaternion Divide(Quaternion quaternion)
        {
            Quaternion r(w, x, y, z);

            double scale = quaternion.w * quaternion.w + quaternion.x * quaternion.x + quaternion.y * quaternion.y + quaternion.z * quaternion.z;

            r.w = (this->w * quaternion.w + this->x * quaternion.x + this->y * quaternion.y + this->z * quaternion.z) / scale;
            r.x = (-this->w * quaternion.x + this->x * quaternion.w + this->y * quaternion.z - this->z * quaternion.y) / scale;
            r.y = (-this->w * quaternion.y - this->x * quaternion.z + this->y * quaternion.w + this->z * quaternion.x) / scale;
            r.z = (-this->w * quaternion.z + this->x * quaternion.y - this->y * quaternion.x + this->z * quaternion.w) / scale;

            return r;
        }

        Quaternion Divide(double scalar) 
        {
            Quaternion r(w, x, y, z);

            r.w = r.w / scalar;
            r.x = r.x / scalar;
            r.y = r.y / scalar;
            r.z = r.z / scalar;

            return r;
        }

        Quaternion Add(Quaternion quaternion)
        {
            Quaternion r(w, x, y, z);

            r.w = this->w + quaternion.w;
            r.x = this->x + quaternion.x;
            r.y = this->y + quaternion.y;
            r.z = this->z + quaternion.z;

            return r;
        }

        Quaternion UnitQuaternion(Quaternion quaternion)
        {
            Quaternion r(w, x, y, z);

            double n = r.Magnitude();

            r.w = r.w / n;
            r.x = r.x / n;
            r.y = r.y / n;
            r.z = r.z / n;

            return r;
        }

        double Magnitude() 
        {
            return sqrt(Normal());
        }

        double Normal() 
        {
            Quaternion r(w, x, y, z);

            return pow(r.w, 2.0) + pow(r.x, 2.0) + pow(r.y, 2.0) + pow(r.z, 2.0);
        }

        Quaternion SphericalInterpolation(Quaternion q1, Quaternion q2, double ratio) 
        {
            q1 = q1.UnitQuaternion();
            q2 = q2.UnitQuaternion();

            double dot = q1.DotProduct(q2);//Cosine between the two quaternions

            if (dot < 0.0)//Shortest path correction
            {
                q1 = q1.AdditiveInverse();
                dot = -dot;
            }

            if (dot > 0.999)//Linearly interpolates if results are close
            {
                return (q1.Add((q2.Subtract(q1)).Multiply(ratio))).UnitQuaternion();
            }
            else
            {
                dot = Constrain(dot, -1, 1);

                double theta0 = acos(dot);
                double theta = theta0 * ratio;

                double f1 = cos(theta) - dot * sin(theta) / sin(theta0);
                double f2 = sin(theta) / sin(theta0);

                return q1.Multiply(f1).Add(q2.Multiply(f2)).UnitQuaternion();
            }
        }

        Quaternion Multiply(double scalar)
        {
            Quaternion r(w, x, y, z);

            r.w = r.w * scalar;
            r.x = r.x * scalar;
            r.y = r.y * scalar;
            r.z = r.z * scalar;
            
            return r;
        }

        Quaternion Subtract(Quaternion quaternion)
        {
            Quaternion r(w, x, y, z);

            r.w = r.w - quaternion.w;
            r.x = r.x - quaternion.x;
            r.y = r.y - quaternion.y;
            r.z = r.z - quaternion.z;

            return r;
        }

        Quaternion UnitQuaternion() 
        {
            Quaternion r(w, x, y, z);

            double n = r.Magnitude();

            r.w = r.w / n;
            r.x = r.x / n;
            r.y = r.y / n;
            r.z = r.z / n;

            return r;
        }

        Quaternion AdditiveInverse() 
        {
            Quaternion r(w, x, y, z);

            r.w = -r.w;
            r.x = -r.x;
            r.y = -r.y;
            r.z = -r.z;

            return r;
        }

        double DotProduct(Quaternion q)
        {
            return (w * q.w) + (x * q.x) + (y * q.y) + (z * q.z);
        }

        float Constrain(float v, float minimum, float maximum)
        {
            if (v > maximum)
                v = maximum;
            else if (v < minimum)
                v = minimum;

            return v;
        }
};

#endif /* _HELPER_3DMATH_H_ */

