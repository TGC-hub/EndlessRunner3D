
using UnityEngine;
using UnityEngine.UI;

public abstract class BaseSlider : MyScriptMonoBehaviour
{
    [Header("Base Button")]
    [SerializeField] public Slider slider;

    protected override void Start()
    {
        base.Start();
        this.AddOnClickEvent();
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadSlider();
    }

    protected virtual void LoadSlider()
    {
        if (this.slider != null) { return; }
        this.slider = GetComponent<Slider>();
    }


    protected virtual void AddOnClickEvent()
    {
        this.slider.onValueChanged.AddListener(this.OnChanged);
    }

    protected abstract void OnChanged(float newValue);
}
