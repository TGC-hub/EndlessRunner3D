using System;
using UnityEngine;

public class CollectorEventOP : MonoBehaviour
{
    public event Action CollectItemMagnet;
    public event Action StopMagnet;
    public event Action CollectItemInvincible;
    public event Action StopInvincible;
    public event Action CollectCoinFishBone;
    public event Action CollectMultiplyer;
    public event Action StopMultiplyer;


    public void CollectMultiplyerEvent()
    {
        CollectMultiplyer?.Invoke();
    }

    public void StopMultiEvent()
    {
        StopMultiplyer?.Invoke();
    }

    public void CollectCoinMagnetEvent()
    {
        CollectItemMagnet?.Invoke();
    }

    public void CollectInvincibleEvent()
    {
        CollectItemInvincible?.Invoke();
    }

    public void StopCoinMagnetEvent()
    {
        StopMagnet?.Invoke();
    }

    public void StopInvincibleEvent()
    {
        StopInvincible?.Invoke();
    }

    public void CollectCoinFishBoneEvent()
    {
        CollectCoinFishBone?.Invoke();
    }
}
