
public class AudioTrashCan : AudioEventByTrigger
{
    protected override void ResetValue()
    {
        base.ResetValue();
        this.m_Clip = AudioClipManager.Instance.trashCan;
    }
 
}
