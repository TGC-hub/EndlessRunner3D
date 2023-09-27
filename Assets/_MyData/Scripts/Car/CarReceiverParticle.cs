
using UnityEngine;

public class CarReceiverParticle : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ParticleManager.Instance.Spawning("Explosion");
            ObserverManager.Instance.CharacterOP.DeathEvent();
            AudioManager.Instance.PlaySoundOneShot(AudioClipManager.Instance.carAccident);
        }
    }

}
