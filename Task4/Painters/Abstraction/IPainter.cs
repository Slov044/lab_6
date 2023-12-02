public interface IPainter
{
    float Delta { get; }
    void MoveX(float x);
    void MoveY(float y);
    void Paint();
}