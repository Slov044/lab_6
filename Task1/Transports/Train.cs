public class Train : Vehicle
{
    public override float Speed => 20;
    public override int Capacity => 100;

    public override void Move()
    {
        throw new NotImplementedException();
    }
}