using Task4;

public abstract class GraphicPrimitive
{
    public Point Centre { get; set; }
    public abstract void Draw(IPainter painter);

    public virtual void Move(Point delta)
    {
        Centre += delta;
    }

    public abstract void Scale(float scale);
}