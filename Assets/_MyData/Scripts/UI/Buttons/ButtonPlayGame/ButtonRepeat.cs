
using UnityEngine.SceneManagement;

public class ButtonRepeat : BaseButton
{
    protected override void OnClick()
    {
        SoundClick();
        SceneManager.LoadScene(1);
    }
}
