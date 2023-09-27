
public class TextPointFishBone : BaseText
{

    protected virtual void FixedUpdate()
    {
        this.text.SetText("X " + ObserverManager.Instance.PointFishBoneOP.PointFish);
    }

}
