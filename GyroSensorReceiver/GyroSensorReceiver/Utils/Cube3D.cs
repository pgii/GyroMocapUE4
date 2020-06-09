using System;
using System.Drawing;
using System.Windows.Forms;

internal class Cube3D
{
    public int Width;
    public int Height;
    public int Depth;

    readonly Camera _camera = new Camera();
    readonly Point3D _cubeOrigin;

    public float RotateX { get; set; }
    public float RotateY { get; set; }
    public float RotateZ { get; set; }

    public Cube3D(int side)
    {
        Width = side;
        Height = side;
        Depth = side;
        _cubeOrigin = new Point3D((float) Width / 2, (float) Height / 2, (float) Depth / 2);
    }

    public static Rectangle GetBounds(PointF[] points)
    {
        float left = points[0].X;
        float right = points[0].X;
        float top = points[0].Y;
        float bottom = points[0].Y;

        for (int i = 1; i < points.Length; i++)
        {
            if (points[i].X < left) left = points[i].X;
            if (points[i].X > right) right = points[i].X;
            if (points[i].Y < top) top = points[i].Y;
            if (points[i].Y > bottom) bottom = points[i].Y;
        }

        return new Rectangle(0, 0, (int)Math.Round(right - left), (int)Math.Round(bottom - top));
    }

    public Bitmap DrawCube(Point drawOrigin)
    {
        PointF[] point3D = new PointF[24];
        Point tmpOrigin = new Point(0, 0);

        Point3D point0 = new Point3D(0, 0, 0);

        float zoom = Screen.PrimaryScreen.Bounds.Width / 1.5f;

        Point3D[] cubePoints = FillCubeVertices(Width, Height, Depth);
        
        Point3D anchorPoint = cubePoints[4];
        float cameraZ = -((anchorPoint.X - _cubeOrigin.X) * zoom / _cubeOrigin.X) + anchorPoint.Z;
        _camera.Position = new Point3D(_cubeOrigin.X, _cubeOrigin.Y, cameraZ);

        cubePoints = Math3D.Translate(cubePoints, _cubeOrigin, point0);
        cubePoints = Math3D.RotateX(cubePoints, RotateX);
        cubePoints = Math3D.RotateY(cubePoints, RotateY);
        cubePoints = Math3D.RotateZ(cubePoints, RotateZ);
        cubePoints = Math3D.Translate(cubePoints, point0, _cubeOrigin);

        for (int i = 0; i < point3D.Length; i++)
        {
            Point3D vec = cubePoints[i];
            if (vec.Z - _camera.Position.Z >= 0)
            {
                point3D[i].X = (int)(-(vec.X - _camera.Position.X) / (-0.1f) * zoom) + drawOrigin.X;
                point3D[i].Y = (int)((vec.Y - _camera.Position.Y) / (-0.1f) * zoom) + drawOrigin.Y;
            }
            else
            {
                tmpOrigin.X = (int)((_cubeOrigin.X - _camera.Position.X) / (_cubeOrigin.Z - _camera.Position.Z) * zoom) + drawOrigin.X;
                tmpOrigin.Y = (int)(-(_cubeOrigin.Y - _camera.Position.Y) / (_cubeOrigin.Z - _camera.Position.Z) * zoom) + drawOrigin.Y;

                point3D[i].X = (vec.X - _camera.Position.X) / (vec.Z - _camera.Position.Z) * zoom + drawOrigin.X;
                point3D[i].Y = -(vec.Y - _camera.Position.Y) / (vec.Z - _camera.Position.Z) * zoom + drawOrigin.Y;

                point3D[i].X = (int)point3D[i].X;
                point3D[i].Y = (int)point3D[i].Y;
            }
        }

        Rectangle bounds = GetBounds(point3D);
        bounds.Width += drawOrigin.X;
        bounds.Height += drawOrigin.Y;

        Bitmap tmpBmp = new Bitmap(bounds.Width, bounds.Height);
        Graphics g = Graphics.FromImage(tmpBmp);

        g.DrawLine(Pens.Black, point3D[0], point3D[1]);
        g.DrawLine(Pens.Black, point3D[1], point3D[2]);
        g.DrawLine(Pens.Black, point3D[2], point3D[3]);
        g.DrawLine(Pens.Black, point3D[3], point3D[0]);

        g.DrawLine(Pens.Black, point3D[4], point3D[5]);
        g.DrawLine(Pens.Black, point3D[5], point3D[6]);
        g.DrawLine(Pens.Black, point3D[6], point3D[7]);
        g.DrawLine(Pens.Black, point3D[7], point3D[4]);

        g.DrawLine(Pens.Black, point3D[8], point3D[9]);
        g.DrawLine(Pens.Black, point3D[9], point3D[10]);
        g.DrawLine(Pens.Black, point3D[10], point3D[11]);
        g.DrawLine(Pens.Black, point3D[11], point3D[8]);

        g.DrawLine(Pens.Black, point3D[12], point3D[13]);
        g.DrawLine(Pens.Black, point3D[13], point3D[14]);
        g.DrawLine(Pens.Black, point3D[14], point3D[15]);
        g.DrawLine(Pens.Black, point3D[15], point3D[12]);

        g.DrawLine(Pens.Black, point3D[16], point3D[17]);
        g.DrawLine(Pens.Black, point3D[17], point3D[18]);
        g.DrawLine(Pens.Black, point3D[18], point3D[19]);
        g.DrawLine(Pens.Black, point3D[19], point3D[16]);

        g.DrawLine(Pens.Black, point3D[20], point3D[21]);
        g.DrawLine(Pens.Black, point3D[21], point3D[22]);
        g.DrawLine(Pens.Black, point3D[22], point3D[23]);
        g.DrawLine(Pens.Black, point3D[23], point3D[20]);

        g.Dispose();

        return tmpBmp;
    }

    public static Point3D[] FillCubeVertices(int width, int height, int depth)
    {
        Point3D[] vertices = new Point3D[24];

        vertices[0] = new Point3D(0, 0, 0);
        vertices[1] = new Point3D(0, height, 0);
        vertices[2] = new Point3D(width, height, 0);
        vertices[3] = new Point3D(width, 0, 0);

        vertices[4] = new Point3D(0, 0, depth);
        vertices[5] = new Point3D(0, height, depth);
        vertices[6] = new Point3D(width, height, depth);
        vertices[7] = new Point3D(width, 0, depth);

        vertices[8] = new Point3D(0, 0, 0);
        vertices[9] = new Point3D(0, 0, depth);
        vertices[10] = new Point3D(0, height, depth);
        vertices[11] = new Point3D(0, height, 0);

        vertices[12] = new Point3D(width, 0, 0);
        vertices[13] = new Point3D(width, 0, depth);
        vertices[14] = new Point3D(width, height, depth);
        vertices[15] = new Point3D(width, height, 0);

        vertices[16] = new Point3D(0, height, 0);
        vertices[17] = new Point3D(0, height, depth);
        vertices[18] = new Point3D(width, height, depth);
        vertices[19] = new Point3D(width, height, 0);

        vertices[20] = new Point3D(0, 0, 0);
        vertices[21] = new Point3D(0, 0, depth);
        vertices[22] = new Point3D(width, 0, depth);
        vertices[23] = new Point3D(width, 0, 0);

        return vertices;
    }
}
