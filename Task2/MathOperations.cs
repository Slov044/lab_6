public class MathOperations
{
    #region Add +

    public byte Add(byte a, byte b)
    {
        return (byte)(a + b);
    }

    public sbyte Add(sbyte a, sbyte b)
    {
        return (sbyte)(a + b);
    }

    public short Add(short a, short b)
    {
        return (short)(a + b);
    }

    public ushort Add(ushort a, ushort b)
    {
        return (ushort)(a + b);
    }

    public int Add(int a, int b)
    {
        return a + b;
    }

    public uint Add(uint a, uint b)
    {
        return a + b;
    }

    public long Add(long a, long b)
    {
        return a + b;
    }

    public ulong Add(ulong a, ulong b)
    {
        return a + b;
    }

    public float Add(float a, float b)
    {
        return a + b;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }

    public decimal Add(decimal a, decimal b)
    {
        return a + b;
    }

    public T Add<T>(T a, T b)
    {
        return (T)((dynamic)a! + (dynamic)b!);
    }

    public T[] Add<T>(T[] a, T[] b)
    {
        T[] bigArray;
        T[] addedArray;

        if (a.Length > b.Length)
        {
            bigArray = a;
            addedArray = b;
        }
        else
        {
            bigArray = b;
            addedArray = a;
        }

        bigArray = (T[])bigArray.Clone();

        for (var index = 0; index < addedArray.Length; index++)
        {
            var value = addedArray[index];

            bigArray[index] = (T)((dynamic)bigArray[index]! + (dynamic)value!);
        }

        return bigArray;
    }

    #endregion

    #region Sub -

    public byte Sub(byte a, byte b)
    {
        return (byte)(a - b);
    }

    public sbyte Sub(sbyte a, sbyte b)
    {
        return (sbyte)(a - b);
    }

    public short Sub(short a, short b)
    {
        return (short)(a - b);
    }

    public ushort Sub(ushort a, ushort b)
    {
        return (ushort)(a - b);
    }

    public int Sub(int a, int b)
    {
        return a - b;
    }

    public uint Sub(uint a, uint b)
    {
        return a - b;
    }

    public long Sub(long a, long b)
    {
        return a - b;
    }

    public ulong Sub(ulong a, ulong b)
    {
        return a - b;
    }

    public float Sub(float a, float b)
    {
        return a - b;
    }

    public double Sub(double a, double b)
    {
        return a - b;
    }

    public decimal Sub(decimal a, decimal b)
    {
        return a - b;
    }

    public T Sub<T>(T a, T b)
    {
        return (T)((dynamic)a! + (dynamic)b!);
    }

    public T[] Sub<T>(T[] a, T[] b)
    {
        T[] bigArray;
        T[] addedArray;

        if (a.Length > b.Length)
        {
            bigArray = a;
            addedArray = b;
        }
        else
        {
            bigArray = b;
            addedArray = a;
        }

        bigArray = (T[])bigArray.Clone();

        for (var index = 0; index < addedArray.Length; index++)
        {
            var value = addedArray[index];

            bigArray[index] = (T)((dynamic)bigArray[index]! - (dynamic)value!);
        }

        return bigArray;
    }

    #endregion

    #region Mul *

    public byte Mul(byte a, byte b)
    {
        return (byte)(a * b);
    }

    public sbyte Mul(sbyte a, sbyte b)
    {
        return (sbyte)(a * b);
    }

    public short Mul(short a, short b)
    {
        return (short)(a * b);
    }

    public ushort Mul(ushort a, ushort b)
    {
        return (ushort)(a * b);
    }

    public int Mul(int a, int b)
    {
        return a * b;
    }

    public uint Mul(uint a, uint b)
    {
        return a * b;
    }

    public long Mul(long a, long b)
    {
        return a * b;
    }

    public ulong Mul(ulong a, ulong b)
    {
        return a * b;
    }

    public float Mul(float a, float b)
    {
        return a * b;
    }

    public double Mul(double a, double b)
    {
        return a * b;
    }

    public decimal Mul(decimal a, decimal b)
    {
        return a * b;
    }

    public T Mul<T>(T a, T b)
    {
        return (T)((dynamic)a! * (dynamic)b!);
    }

    public T[] Mul<T>(T[] a, T[] b)
    {
        T[] bigArray;
        T[] addedArray;

        if (a.Length > b.Length)
        {
            bigArray = a;
            addedArray = b;
        }
        else
        {
            bigArray = b;
            addedArray = a;
        }

        bigArray = (T[])bigArray.Clone();

        for (var index = 0; index < addedArray.Length; index++)
        {
            var value = addedArray[index];

            bigArray[index] = (T)((dynamic)bigArray[index]! * (dynamic)value!);
        }

        return bigArray;
    }

    #endregion
}