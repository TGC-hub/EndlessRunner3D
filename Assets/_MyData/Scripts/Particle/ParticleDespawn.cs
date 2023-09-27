
public class ParticleDespawn : DespawnByDistance
{
    public override void DespawnObject()

    {
        ParticleSpawner.Instance.Despawn(transform.parent);
    }

    protected override void ResetValue()
    {
        base.ResetValue();
        this.disLimit = 10f;
    }
}
