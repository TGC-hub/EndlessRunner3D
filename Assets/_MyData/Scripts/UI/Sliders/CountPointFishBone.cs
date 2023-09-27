
using UnityEngine;

public class CountPointFishBone : MyScriptMonoBehaviour
{
    [SerializeField] protected SliderSkill sliderSkill;
    protected int maxCurrenPointFish = 100;
    public int currenPointFish;

    protected bool isActiveX2 = false;

    protected override void Start()
    {
        base.Start();
        ObserverManager.Instance.CollectorEventOP.CollectCoinFishBone += SetPointFish;
        ObserverManager.Instance.CollectorEventOP.CollectMultiplyer += SetPointFishMulti;
        ObserverManager.Instance.CollectorEventOP.StopMultiplyer += StopPointFishMulti;
        ObserverManager.Instance.ButtonEventOP.OnclickActiveItem += ButtonItemClicked;
    }

    protected virtual void ButtonItemClicked()
    {
        currenPointFish = 0;
    }

    protected virtual void SetPointFish()
    {
        if(currenPointFish > 100) { return; }
        if (isActiveX2 == true) { currenPointFish += 2; }
        else
        {
            currenPointFish++;
        }
    }

    protected virtual void SetPointFishMulti()
    {
        isActiveX2 = true;
    }

    protected virtual void StopPointFishMulti()
    {
        isActiveX2 = false;
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadSlider();
    }

    protected virtual void LoadSlider()
    {
        if (this.sliderSkill != null) { return; }
        this.sliderSkill = transform.GetComponentInChildren<SliderSkill>();
    }


    private void FixedUpdate()
    {
        sliderSkill.SetCurrenMax(maxCurrenPointFish);
        sliderSkill.SetCurren(currenPointFish);
    }

}
