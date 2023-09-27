

public class ItemDespawn : DespawnByDistance
{
    public override void DespawnObject()

    {
        ItemSpawner.Instance.Despawn(transform.parent);
    }

    protected override void ResetValue()
    {
        base.ResetValue();
        this.disLimit = 10f;
    }
}
