using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Вектор
{
    class Vector
    {
        double x;
        public double X { get { return x; } set { x = value; } }

        double y;
        public double Y { get { return y; } set { y = value; } }

        double z;
        public double Z { get { return z; } set { z = value; } }

        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Vector operator +(Vector  a, Vector b)
        {
            return new Vector(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }

        public static double operator *(Vector a, Vector b)
        {
            return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
        }

        public static double Angle(Vector a, Vector b)
        {
            var angle = (a * b) / (a.Length() * b.Length());
            if (angle > 1 || a.Length()==0 || b.Length()==0)
                return 0;
            else if (angle < -1)
                return Math.PI;
            else
                return (Math.Acos((a * b) / (a.Length() * b.Length())));
        }
        public double Length()
        {
            return Math.Round(Math.Sqrt(x * x + y * y + z * z), 2);
        }
    }
}
