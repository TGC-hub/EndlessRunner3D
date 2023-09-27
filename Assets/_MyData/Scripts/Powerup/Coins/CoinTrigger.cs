
using UnityEngine;

public class CoinTrigger : MyScriptMonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ReceiverItem"))
        {
            CoinsSpawn.Instance.Despawn(this.transform.parent);
            SpawningParticle();
        }
    }

    protected virtual void SpawningParticle()
    {
        ParticleManager.Instance.Spawning("FishBone");
    }

}
