using System;
using System.Drawing;
using System.Windows.Forms;

internal class Cube3D
{
    public int width = 0;
    public int height = 0;
    public int depth = 0;

    Camera camera = new Camera();
    Point3D cubeOrigin;

    public float RotateX { get; set; }
    public float RotateY { get; set; }
    public float RotateZ { get; set; }

    public Cube3D(int side)
    {
        width = side;
        height = side;
        depth = side;
        cubeOrigin = new Point3D(width / 2, height / 2, depth / 2);
    }

    public Cube3D(int side, Point3D origin)
    {
        width = side;
        height = side;
        depth = side;
        cubeOrigin = origin;
    }

    public Cube3D(int Width, int Height, int Depth)
    {
        width = Width;
        height = Height;
        depth = Depth;
        cubeOrigin = new Point3D(width / 2, height / 2, depth / 2);
    }

    public Cube3D(int Width, int Height, int Depth, Point3D origin)
    {
        width = Width;
        height = Height;
        depth = Depth;
        cubeOrigin = origin;
    }

    public static Rectangle getBounds(PointF[] points)
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

    public Bitmap drawCube(Point drawOrigin)
    {
        PointF[] point3D = new PointF[24];
        Point tmpOrigin = new Point(0, 0);

        Point3D point0 = new Point3D(0, 0, 0);

        float zoom = Screen.PrimaryScreen.Bounds.Width / 1.5f;

        Point3D[] cubePoints = fillCubeVertices(width, height, depth);
        
        Point3D anchorPoint = cubePoints[4];
        float cameraZ = -((anchorPoint.X - cubeOrigin.X) * zoom / cubeOrigin.X) + anchorPoint.Z;
        camera.Position = new Point3D(cubeOrigin.X, cubeOrigin.Y, cameraZ);

        cubePoints = Math3D.Translate(cubePoints, cubeOrigin, point0);
        cubePoints = Math3D.RotateX(cubePoints, RotateX);
        cubePoints = Math3D.RotateY(cubePoints, RotateY);
        cubePoints = Math3D.RotateZ(cubePoints, RotateZ);
        cubePoints = Math3D.Translate(cubePoints, point0, cubeOrigin);

        Point3D vec;
        for (int i = 0; i < point3D.Length; i++)
        {
            vec = cubePoints[i];
            if (vec.Z - camera.Position.Z >= 0)
            {
                point3D[i].X = (int)(-(vec.X - camera.Position.X) / (-0.1f) * zoom) + drawOrigin.X;
                point3D[i].Y = (int)((vec.Y - camera.Position.Y) / (-0.1f) * zoom) + drawOrigin.Y;
            }
            else
            {
                tmpOrigin.X = (int)((cubeOrigin.X - camera.Position.X) / (cubeOrigin.Z - camera.Position.Z) * zoom) + drawOrigin.X;
                tmpOrigin.Y = (int)(-(cubeOrigin.Y - camera.Position.Y) / (cubeOrigin.Z - camera.Position.Z) * zoom) + drawOrigin.Y;

                point3D[i].X = (float)((vec.X - camera.Position.X) / (vec.Z - camera.Position.Z) * zoom + drawOrigin.X);
                point3D[i].Y = (float)(-(vec.Y - camera.Position.Y) / (vec.Z - camera.Position.Z) * zoom + drawOrigin.Y);

                point3D[i].X = (int)point3D[i].X;
                point3D[i].Y = (int)point3D[i].Y;
            }
        }

        Rectangle bounds = getBounds(point3D);
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

    public static Point3D[] fillCubeVertices(int width, int height, int depth)
    {
        Point3D[] verts = new Point3D[24];

        verts[0] = new Point3D(0, 0, 0);
        verts[1] = new Point3D(0, height, 0);
        verts[2] = new Point3D(width, height, 0);
        verts[3] = new Point3D(width, 0, 0);

        verts[4] = new Point3D(0, 0, depth);
        verts[5] = new Point3D(0, height, depth);
        verts[6] = new Point3D(width, height, depth);
        verts[7] = new Point3D(width, 0, depth);

        verts[8] = new Point3D(0, 0, 0);
        verts[9] = new Point3D(0, 0, depth);
        verts[10] = new Point3D(0, height, depth);
        verts[11] = new Point3D(0, height, 0);

        verts[12] = new Point3D(width, 0, 0);
        verts[13] = new Point3D(width, 0, depth);
        verts[14] = new Point3D(width, height, depth);
        verts[15] = new Point3D(width, height, 0);

        verts[16] = new Point3D(0, height, 0);
        verts[17] = new Point3D(0, height, depth);
        verts[18] = new Point3D(width, height, depth);
        verts[19] = new Point3D(width, height, 0);

        verts[20] = new Point3D(0, 0, 0);
        verts[21] = new Point3D(0, 0, depth);
        verts[22] = new Point3D(width, 0, depth);
        verts[23] = new Point3D(width, 0, 0);

        return verts;
    }
}
