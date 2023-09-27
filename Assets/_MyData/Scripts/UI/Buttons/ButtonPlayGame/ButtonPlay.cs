
public class ButtonPlay : BaseButton
{
    protected override void OnClick()
    {
        SoundClick();
        UIMidCtrl.Intance.PanelPause.Hide();
        ObserverManager.Instance.ButtonEventOP.PlayEvent();
    }
}
