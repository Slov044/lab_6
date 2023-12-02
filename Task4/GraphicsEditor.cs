public class GraphicsEditor
{
    private readonly IPainter _painter;

    private readonly List<GraphicPrimitive> _primitives = new();

    public GraphicsEditor(IPainter painter)
    {
        _painter = painter;
    }

    public void Add(GraphicPrimitive primitive)
    {
        _primitives.Add(primitive);
    }

    public void Draw()
    {
        foreach (var primitive in _primitives) primitive.Draw(_painter);
    }
}