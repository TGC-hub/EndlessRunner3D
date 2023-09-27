
using UnityEngine;

public class ItemReceiver : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ReceiverItem"))
        {
            ItemSpawner.Instance.Despawn(transform.parent);
        }   
    }
}
