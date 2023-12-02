public class ConsolePainter : IPainter
{
    public void MoveX(float x)
    {
        if (x < 0)
            return;

        Console.CursorLeft = (int)x;
    }

    public void MoveY(float y)
    {
        if (y < 0)
            return;

        Console.CursorTop = (int)y;
    }

    public void Paint()
    {
        Console.Write('*');
        Console.CursorLeft--;
    }

    public float Delta => 1f;
}