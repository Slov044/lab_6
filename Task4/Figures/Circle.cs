namespace Task4.Figures;

public class Circle : GraphicPrimitive
{
    public Circle(float radius)
    {
        Radius = radius;
    }

    public float Radius { get; set; }

    public override void Draw(IPainter painter)
    {
        var delta = painter.Delta;
        var squareRadius = Radius * Radius;

        for (var y = Centre.Y - Radius; y < Centre.Y + Radius; y += delta)
        for (var x = Centre.X - Radius; x < Centre.X + Radius; x += delta)
        {
            var dx = Centre.X - x;
            var dy = Centre.Y - y;

            if (dx * dx + dy * dy <= squareRadius) painter.SetPixel(x, y);
        }
    }

    public override void Scale(float scale)
    {
        Radius *= scale;
    }
}