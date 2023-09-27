
using UnityEngine;

public class ReceiverParticle : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ReceiverItem"))
        {
            SpawningParticle();
        }
    }

    protected virtual void SpawningParticle()
    {
    }
 
}
