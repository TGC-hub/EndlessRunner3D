
using UnityEngine;

public class DogTriggerActive : EventActiveByDistance
{
    [SerializeField] protected DogCtrl dogCtrl;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadDogCtrl();
    }

    protected virtual void LoadDogCtrl()
    {
        if (this.dogCtrl != null) { return; }
        else
        {
            this.dogCtrl = transform.parent.GetComponent<DogCtrl>();
        }
    }
    protected override void ActivateFeature()
    {
        base.ActivateFeature();
        this.dogCtrl.DogTrap.moveSpeed = 7;
    }

    protected override void StopActivateFeature()
    {
        this.dogCtrl.DogTrap.moveSpeed = 0;
    }

    protected override void ResetValue()
    {
        base.ResetValue();
        this.disLimit = 10f;
    }
}
