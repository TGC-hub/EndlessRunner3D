
using UnityEngine;

public class EventActiveByCollider : EventActive
{
    protected bool isActive = false;

    // can add CompareTag to OnTrigger

    protected virtual void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isActive = true;
            OneActive();
        }
    }

    protected virtual void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isActive = false;
        }
    }

    protected override bool CanActive()
    {
        return isActive;
    }

    protected virtual void OneActive() { }

}
