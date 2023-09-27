using UnityEngine;

public class CountDownTimeSliderOP : MyScriptMonoBehaviour
{
    [SerializeField] protected Transform slider;
    [SerializeField] protected SliderTimePowUp sliderTimePowUp;
    [SerializeField] protected CountdownTimer countdownTimer;


    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadSliderTime();
        LoadCountDown();
        LoadGameObjectSlider();
    }

    protected virtual void LoadGameObjectSlider()
    {
        if (this.slider != null) { return; }
        this.slider = transform.Find("SliderTimePowUp");
        this.slider.gameObject.SetActive(false);
    }

    protected virtual void LoadSliderTime()
    {
        if (this.sliderTimePowUp != null) { return; }
        this.sliderTimePowUp = GetComponentInChildren<SliderTimePowUp>();
    }

    protected virtual void LoadCountDown()
    {
        if (this.countdownTimer != null) { return; }
        this.countdownTimer = transform.GetComponent<CountdownTimer>();
    }

    protected override void Start()
    {
        base.Start();
        ObserverManager.Instance.CollectorEventOP.CollectItemMagnet += SetActive;
        ObserverManager.Instance.CollectorEventOP.StopMagnet += StopActive;
        ObserverManager.Instance.CollectorEventOP.CollectItemInvincible += SetActive;
        ObserverManager.Instance.CollectorEventOP.StopInvincible += StopActive;
        ObserverManager.Instance.CollectorEventOP.StopMultiplyer += StopActive;
        ObserverManager.Instance.CollectorEventOP.CollectMultiplyer += SetActive;
    }


    private void StopActive()
    {
        slider.gameObject.SetActive(false);
    }

    private void FixedUpdate()
    {
        sliderTimePowUp.SetCurrenMax(countdownTimer.TimeMax);
        sliderTimePowUp.SetCurren(countdownTimer.CountdownValue);
    }

    private void SetActive()
    {
        slider.gameObject.SetActive(true);
        countdownTimer.StartCountdown();
    }
}
