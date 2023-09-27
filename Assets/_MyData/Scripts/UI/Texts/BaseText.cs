
using TMPro;
using UnityEngine;

public abstract class BaseText : MyScriptMonoBehaviour
{
    [Header("Base Text")]
    [SerializeField] protected TextMeshProUGUI text;


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadText();
    }

    protected virtual void LoadText()
    {
        if (this.text != null) { return; }
        this.text = GetComponent<TextMeshProUGUI>();
    }


}
