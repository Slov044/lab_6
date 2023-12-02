namespace Task4.Figures;

public class GroupPrimitive : GraphicPrimitive
{
    private readonly List<GraphicPrimitive> _children = new();

    public override void Draw(IPainter painter)
    {
        ActionInvoke(p => p.Draw(painter));
    }

    public override void Scale(float scale)
    {
        ActionInvoke(p => p.Scale(scale));
    }

    public override void Move(Point delta)
    {
        base.Move(delta);
        ActionInvoke(p => p.Move(delta));
    }

    private void ActionInvoke(Action<GraphicPrimitive> action)
    {
        foreach (var primitive in _children) action(primitive);
    }

    public void Add(GraphicPrimitive primitive)
    {
        _children.Add(primitive);
    }

    public void Remove(GraphicPrimitive primitive)
    {
        _children.Remove(primitive);
    }
}