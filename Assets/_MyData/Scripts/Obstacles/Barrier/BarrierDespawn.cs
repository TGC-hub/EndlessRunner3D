
public class BarrierDespawn : DespawnByDistance
{
    public override void DespawnObject()

    {
        BarrierSpawner.Instance.Despawn(transform.parent);
    }

    protected override void ResetValue()
    {
        base.ResetValue();
        this.disLimit = 30f;
    }
}
