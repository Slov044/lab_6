public static class PainterExtensions
{
    public static void Move<T>(this T painter, float x, float y) where T : IPainter
    {
        painter.MoveX(x);
        painter.MoveY(y);
    }

    public static void SetPixel<T>(this T painter, float x, float y) where T : IPainter
    {
        painter.Move(x, y);
        painter.Paint();
    }
}