using UnityEngine;

public class NextButton : BaseButton
{
    [SerializeField] protected SelectCharacter selectCharacter;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadSelectCharacter();
    }

    protected virtual void LoadSelectCharacter()
    {
        if(selectCharacter != null) { return; }
        selectCharacter = GameObject.FindGameObjectWithTag("SelectionCharacter").GetComponent<SelectCharacter>();
    }
    protected override void OnClick()
    {
        if(selectCharacter.curren == selectCharacter.charater.Count - 1) { return; }
        selectCharacter.YourSelection(1);
        SoundClick();
    }
}
