using System.ComponentModel.DataAnnotations;

public abstract class Vehicle
{
    [Range(0, int.MaxValue)]
    public abstract float Speed { get; }

    [Range(0, int.MaxValue)]
    public abstract int Capacity { get; }

    public abstract void Move();
}