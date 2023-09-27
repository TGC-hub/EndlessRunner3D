
using UnityEngine.SceneManagement;

public class ButtonMenu : BaseButton
{
    protected override void OnClick()
    {
        SoundClick();
        SceneManager.LoadScene(0);
    }
}
