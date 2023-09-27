
using UnityEngine;

public class EventActiveByDistance : EventActive
{
    [SerializeField] protected float disLimit = 70f;
    [SerializeField] protected float distance = 0f;
    [SerializeField] protected Transform player;

    protected override void LoadComponents()
    {
        this.LoadPlayer();
    }

    protected virtual void LoadPlayer()
    {
        if (this.player != null) { return; }
        else
        {
            this.player = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }
    protected override bool CanActive()
    {
        this.distance = Vector3.Distance(transform.parent.position, this.player.position);
        if (this.distance < this.disLimit) { return true; }
        else
        {
            return false;
        }
    }
}
