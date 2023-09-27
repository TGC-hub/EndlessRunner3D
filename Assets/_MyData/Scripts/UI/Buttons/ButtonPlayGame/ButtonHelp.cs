
public class ButtonHelp : BaseButton
{
    protected override void OnClick()
    {
        SoundClick();
        UIMidCtrl.Intance.PanelTutorial.Appear();
        UIMidCtrl.Intance.PanelPause.Hide();
    }
}
