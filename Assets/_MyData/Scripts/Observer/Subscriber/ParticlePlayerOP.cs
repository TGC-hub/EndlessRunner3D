
using UnityEngine;

public class ParticlePlayerOP : MonoBehaviour
{
    [SerializeField] protected GameObject magnetParticle;
    [SerializeField] protected GameObject multiplierParticles;
    [SerializeField] protected GameObject invincibilityParticles;

    protected virtual void Start()
    {
        ObserverManager.Instance.CollectorEventOP.CollectItemMagnet += SetActiveSuction;
        ObserverManager.Instance.CollectorEventOP.StopMagnet += StopMagnet;
        ObserverManager.Instance.CollectorEventOP.CollectItemInvincible += SetActiveInvincible;
        ObserverManager.Instance.CollectorEventOP.StopInvincible += StopInvincible;
        ObserverManager.Instance.CollectorEventOP.StopMultiplyer += StopMulti;
        ObserverManager.Instance.CollectorEventOP.CollectMultiplyer += SetActiveMulti;

    }

    protected virtual void SetActiveMulti()
    {
        multiplierParticles.SetActive(true);
    }

    protected virtual void StopMulti()
    {
        multiplierParticles.SetActive(false);
    }

    protected virtual void SetActiveSuction()
    {
        magnetParticle.SetActive(true);
    }

    protected virtual void SetActiveInvincible()
    {
        invincibilityParticles.SetActive(true);
    }

    protected virtual void StopMagnet()
    {
        magnetParticle.SetActive(false);
    }

    protected virtual void StopInvincible()
    {
        invincibilityParticles.SetActive(false);
    }

}
