
public class ButtonSkillInvicible : BaseButton
{
    protected override void OnClick()
    {

        if (ObserverManager.Instance.CollectorOP.IsCollect == true)
        {
            SoundClick();
            ObserverManager.Instance.CollectorOP.StartInvincibilityItem();
            ObserverManager.Instance.ButtonEventOP.OnclickActiveItemEvent();
        }
    }
}
