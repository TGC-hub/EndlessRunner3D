
public class ButtonSkillMultiplyer : BaseButton
{
    protected override void OnClick()
    {   
        if (ObserverManager.Instance.CollectorOP.IsCollect == true)
        {
            ObserverManager.Instance.CollectorOP.StartMultiplyerItem();
            ObserverManager.Instance.ButtonEventOP.OnclickActiveItemEvent();

        }
    }
}
