
public class ButtonPause : BaseButton
{
    protected override void OnClick()
    {
        if(PlayerManager.Instance.PlayerMovement.logicGameSpeed == 0) { return; }
        SoundClick();
        UIMidCtrl.Intance.PanelPause.Appear();
        ObserverManager.Instance.ButtonEventOP.PauseEvent();
    }
}
