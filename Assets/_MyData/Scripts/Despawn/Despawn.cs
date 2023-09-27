
public abstract class Despawn : MyScriptMonoBehaviour
{
    protected virtual void FixedUpdate()
    {
        Despawning();
    }

    protected virtual void Despawning()
    {
        if (!CanDespawn()) { return; }
        else
        {
            DespawnObject();
        }
    }
    public virtual void DespawnObject()
    {
        Destroy(transform.parent.gameObject);
    }

    protected abstract bool CanDespawn();
}
