
public class DestroyHouse : DespawnByDistance
{
    protected override void ResetValue()
    {
        base.ResetValue();
        this.disLimit = 50f;
    }
}
