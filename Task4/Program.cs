// See https://aka.ms/new-console-template for more information

using System.Text;
using Task4;
using Task4.Figures;

public static class Program
{
    private static readonly ConsolePainter ConsolePainter = new();
    private static readonly GraphicsEditor GraphicsEditor = new(ConsolePainter);


    public static void Main(string[] args)
    {
        Console.InputEncoding = Console.OutputEncoding = Encoding.UTF8;

        var group = new GroupPrimitive();
        group.Add(new Circle(5) { Centre = new Point(2, 4) });
        group.Add(new Circle(5) { Centre = new Point(2, 12) });
        group.Move(new Point(4, 3));
        GraphicsEditor.Add(group);

        //GraphicsEditor.Add(new Rectangle(3, 3) {Centre = new Point(12, 7)});
        //GraphicsEditor.Add(new Circle(8) {Centre = new Point(12, 12)});

        while (true)
        {
            Console.Clear();
            GraphicsEditor.Draw();
            var figure = GetFigure();
            figure.Centre = RandomPoint();
            GraphicsEditor.Add(figure);
        }
    }

    private static GraphicPrimitive GetFigure()
    {
        var random = Random.Shared;
        while (true)
        {
            var key = Console.ReadKey(true).Key;

            switch (key)
            {
                case ConsoleKey.D1:
                    return new Circle((float)(random.NextDouble() * 10 + 3));
                case ConsoleKey.D2:
                    return new Rectangle(random.Next(2, 10), random.Next(4, 10));
            }
        }
    }

    private static Point RandomPoint()
    {
        return new Point(Random.Shared.Next(0, 40), Random.Shared.Next(0, 40));
    }
}