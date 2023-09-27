
public class OtherDespawn : DespawnByDistance
{
    public override void DespawnObject()

    {
        OtherSpawner.Instance.Despawn(transform.parent);
    }

    protected override void ResetValue()
    {
        base.ResetValue();
        this.disLimit = 50f;
    }
}
