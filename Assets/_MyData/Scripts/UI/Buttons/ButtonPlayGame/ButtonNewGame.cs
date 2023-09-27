
using UnityEngine.SceneManagement;

public class ButtonNewGame : BaseButton
{
    protected override void OnClick()
    {
        SoundClick();
        SceneManager.LoadScene(1);
    }

}
