using UnityEngine;

public class PreviousButton : BaseButton
{
    [SerializeField] protected SelectCharacter selectCharacter;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadSelectCharacter();
    }

    protected virtual void LoadSelectCharacter()
    {
        if (selectCharacter != null) { return; }
        selectCharacter = GameObject.FindGameObjectWithTag("SelectionCharacter").GetComponent<SelectCharacter>();
    }
    protected override void OnClick()
    {
        if (selectCharacter.curren == 0) { return; }
        selectCharacter.YourSelection(-1);
        SoundClick();
    }
}
