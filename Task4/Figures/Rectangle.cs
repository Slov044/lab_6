namespace Task4.Figures;

public class Rectangle : GraphicPrimitive
{
    public Rectangle(float width, float height)
    {
        Width = width;
        Height = height;
    }

    public float Width { get; set; }
    public float Height { get; set; }

    public override void Draw(IPainter painter)
    {
        var halfWidth = Width / 2;
        var halfHeight = Height / 2;
        var delta = painter.Delta;

        for (var x = Centre.X - halfWidth; x < Centre.X + halfWidth; x += delta)
        for (var y = Centre.Y - halfHeight; y < Centre.Y + halfHeight; y += delta)
            painter.SetPixel(x, y);
    }

    public override void Scale(float scale)
    {
        Width *= scale;
        Height *= scale;
    }
}