
public class ButtonExit : BaseButton
{
    protected override void OnClick()
    {
        UIMidCtrl.Intance.PanelTutorial.Hide();
        UIMidCtrl.Intance.PanelPause.Appear();
        SoundClick();

    }
}
