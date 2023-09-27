
public class AudioWheelieBin : AudioEventByTrigger
{
    protected override void ResetValue()
    {
        base.ResetValue();
        this.m_Clip = AudioClipManager.Instance.wheelieBin;
    }
}
