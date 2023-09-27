
public class ButtonSkillMagnet : BaseButton
{
    protected override void OnClick()
    {
        if (ObserverManager.Instance.CollectorOP.IsCollect == true)
        {
            SoundClick();
            ObserverManager.Instance.CollectorOP.StartMagnetItem();
            ObserverManager.Instance.ButtonEventOP.OnclickActiveItemEvent();

        }
    }
}   
