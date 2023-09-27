using UnityEngine;

public class ButtonQuit : BaseButton
{
    protected override void OnClick()
    {
        SoundClick();
        Application.Quit();
    }
}
