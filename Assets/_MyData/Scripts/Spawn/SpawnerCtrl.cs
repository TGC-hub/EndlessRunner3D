
public abstract class SpawnerCtrl : MyScriptMonoBehaviour
{
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadSpawner();
        this.LoadSpawnPoints();
    }

    protected virtual void LoadSpawner()
    {
    }

    protected virtual void LoadSpawnPoints()
    {
    }
}
