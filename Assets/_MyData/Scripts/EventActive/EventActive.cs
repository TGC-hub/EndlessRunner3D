
public abstract class EventActive : MyScriptMonoBehaviour
{
    protected virtual void FixedUpdate()
    {
        this.Activated();
    }

    protected virtual void Activated()
    {
        if (!this.CanActive()) { StopActivateFeature(); }
        else
        {
            this.ActivateFeature();
        }
    }

    protected virtual void StopActivateFeature()
    {
        return;
    }
    protected virtual void ActivateFeature()
    {
    }

    protected abstract bool CanActive();

}
