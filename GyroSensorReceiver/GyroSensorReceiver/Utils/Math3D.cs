using System;

internal class Math3D
{
    public static Point3D RotateX(Point3D point3D, float degrees)
    {
        float cDegrees = (float)Math.PI * degrees / 180.0f;
        float cosDegrees = (float)Math.Cos(cDegrees);
        float sinDegrees = (float)Math.Sin(cDegrees);
        float y = point3D.Y * cosDegrees + point3D.Z * sinDegrees;
        float z = point3D.Y * -sinDegrees + point3D.Z * cosDegrees;
        return new Point3D(point3D.X, y, z);
    }

    public static Point3D RotateY(Point3D point3D, float degrees)
    {
        float cDegrees = (float)Math.PI * degrees / 180.0f;
        float cosDegrees = (float)Math.Cos(cDegrees);
        float sinDegrees = (float)Math.Sin(cDegrees);
        float x = point3D.X * cosDegrees + point3D.Z * sinDegrees;
        float z = point3D.X * -sinDegrees + point3D.Z * cosDegrees;
        return new Point3D(x, point3D.Y, z);
    }

    public static Point3D RotateZ(Point3D point3D, float degrees)
    {
        float cDegrees = (float)Math.PI * degrees / 180.0f;
        float cosDegrees = (float)Math.Cos(cDegrees);
        float sinDegrees = (float)Math.Sin(cDegrees);
        float x = point3D.X * cosDegrees + point3D.Y * sinDegrees;
        float y = point3D.X * -sinDegrees + point3D.Y * cosDegrees;
        return new Point3D(x, y, point3D.Z);
    }

    public static Point3D Translate(Point3D points3D, Point3D oldOrigin, Point3D newOrigin)
    {
        Point3D difference = new Point3D(newOrigin.X - oldOrigin.X, newOrigin.Y - oldOrigin.Y, newOrigin.Z - oldOrigin.Z);
        points3D.X += difference.X;
        points3D.Y += difference.Y;
        points3D.Z += difference.Z;
        return points3D;
    }

    public static Point3D[] RotateX(Point3D[] points3D, float degrees)
    {
        for (int i = 0; i < points3D.Length; i++)
            points3D[i] = RotateX(points3D[i], degrees);
        return points3D;
    }

    public static Point3D[] RotateY(Point3D[] points3D, float degrees)
    {
        for (int i = 0; i < points3D.Length; i++)
            points3D[i] = RotateY(points3D[i], degrees);
        return points3D;
    }

    public static Point3D[] RotateZ(Point3D[] points3D, float degrees)
    {
        for (int i = 0; i < points3D.Length; i++)
            points3D[i] = RotateZ(points3D[i], degrees);
        return points3D;
    }

    public static Point3D[] Translate(Point3D[] points3D, Point3D oldOrigin, Point3D newOrigin)
    {
        for (int i = 0; i < points3D.Length; i++)
            points3D[i] = Translate(points3D[i], oldOrigin, newOrigin);
        return points3D;
    }
}
