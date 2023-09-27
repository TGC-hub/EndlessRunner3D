
using UnityEngine;

public class PointFishBoneOP : MonoBehaviour
{
    [SerializeField] protected int pointFish = 0;
    public int PointFish => pointFish;

    protected bool isActiveX2 = false;

    protected virtual void Start()
    {
        ObserverManager.Instance.CollectorEventOP.CollectCoinFishBone += SetPointFish;
        ObserverManager.Instance.CollectorEventOP.CollectMultiplyer += SetPointFishMulti;
        ObserverManager.Instance.CollectorEventOP.StopMultiplyer += StopPointFishMulti;

    }

    protected virtual void SetPointFish()
    {
        if(isActiveX2 == true) { pointFish += 2; }
        else
        {
            pointFish++;
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

}
