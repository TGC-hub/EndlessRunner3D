
using UnityEngine;

public class SliderBar : BaseSlider
{
    [SerializeField] protected float maxCurren;
    [SerializeField] protected float curren;

    protected virtual void FixedUpdate()
    {
        this.ShowCurren();
    }

    protected virtual void ShowCurren()
    {
        float timePercent = this.curren / this.maxCurren;
        this.slider.value = timePercent;
    }

    protected override void OnChanged(float newValue)
    {

    }

    public void SetCurrenMax(float maxCurren)
    {
        this.maxCurren = maxCurren;
    }

    public void SetCurren(float curren)
    {
        this.curren = curren;
    }
}
