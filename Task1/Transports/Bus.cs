public class Bus : Vehicle
{
    public override float Speed => 25;
    public override int Capacity => 30;

    public override void Move()
    {
        throw new NotImplementedException();
    }
}