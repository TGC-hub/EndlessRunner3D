
public class AnimalDespawn : DespawnByDistance
{
    public override void DespawnObject()
    {
        AnimalSpawner.Instance.Despawn(transform.parent);
    }

    protected override void ResetValue()
    {
        base.ResetValue();
        this.disLimit = 10f;
    }
}
