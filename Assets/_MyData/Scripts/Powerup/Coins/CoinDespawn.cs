
public class CoinDespawn : DespawnByDistance
{
    public override void DespawnObject()

    {
        CoinsSpawn.Instance.Despawn(transform.parent);
    }

    protected override void ResetValue()
    {
        base.ResetValue();
        this.disLimit = 25f;
    }
}
