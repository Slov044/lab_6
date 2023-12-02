namespace Task3;

internal class Quaternion : IEquatable<Quaternion>
{
    public Quaternion(double w, double x, double y, double z)
    {
        W = w;
        X = x;
        Y = y;
        Z = z;
    }

    public double W { get; }
    public double X { get; }
    public double Y { get; }
    public double Z { get; }

    public bool Equals(Quaternion? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return W.Equals(other.W) && X.Equals(other.X) && Y.Equals(other.Y) && Z.Equals(other.Z);
    }

    public static Quaternion operator +(Quaternion left, Quaternion right)
    {
        return new Quaternion(
            left.W + right.W,
            left.X + right.X,
            left.Y + right.Y,
            left.Z + right.Z);
    }

    public static Quaternion operator -(Quaternion q1, Quaternion q2)
    {
        return new Quaternion(q1.W - q2.W, q1.X - q2.X, q1.Y - q2.Y, q1.Z - q2.Z);
    }

    public static Quaternion operator *(Quaternion q1, Quaternion q2)
    {
        var w = q1.W * q2.W - q1.X * q2.X - q1.Y * q2.Y - q1.Z * q2.Z;
        var x = q1.W * q2.X + q1.X * q2.W + q1.Y * q2.Z - q1.Z * q2.Y;
        var y = q1.W * q2.Y - q1.X * q2.Z + q1.Y * q2.W + q1.Z * q2.X;
        var z = q1.W * q2.Z + q1.X * q2.Y - q1.Y * q2.X + q1.Z * q2.W;

        return new Quaternion(w, x, y, z);
    }

    public double Norm()
    {
        return Math.Sqrt(W * W + X * X + Y * Y + Z * Z);
    }

    public Quaternion Conjugate()
    {
        return new Quaternion(W, -X, -Y, -Z);
    }

    public Quaternion Inverse()
    {
        var normSquared = Norm();
        if (normSquared == 0)
            throw new InvalidOperationException("Quaternion has zero norm, cannot compute inverse.");

        var factor = 1.0 / normSquared;
        return new Quaternion(W * factor, -X * factor, -Y * factor, -Z * factor);
    }

    public static bool operator ==(Quaternion q1, Quaternion q2)
    {
        return q1.Equals(q2);
    }

    public static bool operator !=(Quaternion q1, Quaternion q2)
    {
        return !q1.Equals(q2);
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((Quaternion)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(W, X, Y, Z);
    }

    public double[,] ToRotationMatrix()
    {
        var matrix = new double[3, 3];

        var xx = X * X;
        var xy = X * Y;
        var xz = X * Z;
        var xw = X * W;

        var yy = Y * Y;
        var yz = Y * Z;
        var yw = Y * W;

        var zz = Z * Z;
        var zw = Z * W;

        matrix[0, 0] = 1 - 2 * (yy + zz);
        matrix[0, 1] = 2 * (xy - zw);
        matrix[0, 2] = 2 * (xz + yw);

        matrix[1, 0] = 2 * (xy + zw);
        matrix[1, 1] = 1 - 2 * (xx + zz);
        matrix[1, 2] = 2 * (yz - xw);

        matrix[2, 0] = 2 * (xz - yw);
        matrix[2, 1] = 2 * (yz + xw);
        matrix[2, 2] = 1 - 2 * (xx + yy);

        return matrix;
    }

    public static Quaternion FromRotationMatrix(double[,] matrix)
    {
        var trace = matrix[0, 0] + matrix[1, 1] + matrix[2, 2];

        if (trace > 0)
        {
            var s = 0.5 / Math.Sqrt(trace + 1.0);
            var w = 0.25 / s;
            var x = (matrix[2, 1] - matrix[1, 2]) * s;
            var y = (matrix[0, 2] - matrix[2, 0]) * s;
            var z = (matrix[1, 0] - matrix[0, 1]) * s;

            return new Quaternion(w, x, y, z);
        }

        if (matrix[0, 0] > matrix[1, 1] && matrix[0, 0] > matrix[2, 2])
        {
            var s = 2.0 * Math.Sqrt(1.0 + matrix[0, 0] - matrix[1, 1] - matrix[2, 2]);
            var w = (matrix[2, 1] - matrix[1, 2]) / s;
            var x = 0.25 * s;
            var y = (matrix[0, 1] + matrix[1, 0]) / s;
            var z = (matrix[0, 2] + matrix[2, 0]) / s;

            return new Quaternion(w, x, y, z);
        }

        if (matrix[1, 1] > matrix[2, 2])
        {
            var s = 2.0 * Math.Sqrt(1.0 + matrix[1, 1] - matrix[0, 0] - matrix[2, 2]);
            var w = (matrix[0, 2] - matrix[2, 0]) / s;
            var x = (matrix[0, 1] + matrix[1, 0]) / s;
            var y = 0.25 * s;
            var z = (matrix[1, 2] + matrix[2, 1]) / s;

            return new Quaternion(w, x, y, z);
        }
        else
        {
            var s = 2.0 * Math.Sqrt(1.0 + matrix[2, 2] - matrix[0, 0] - matrix[1, 1]);
            var w = (matrix[1, 0] - matrix[0, 1]) / s;
            var x = (matrix[0, 2] + matrix[2, 0]) / s;
            var y = (matrix[1, 2] + matrix[2, 1]) / s;
            var z = 0.25 * s;

            return new Quaternion(w, x, y, z);
        }
    }

    public void Deconstruct(out double x, out double y, out double z, out double w)
    {
        x = X;
        y = Y;
        z = Z;
        w = W;
    }
}