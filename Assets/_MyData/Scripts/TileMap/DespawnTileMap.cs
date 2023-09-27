
public class DespawnTileMap : DespawnByDistance
{
    public override void DespawnObject()
    {
        TileMapSpawner.Instance.Despawn(transform.parent);
    }

    protected override void ResetValue()
    {
        this.disLimit = 30f;
    }
}
