using System.Collections.Generic;
using UnityEngine;

public abstract class AnimalMovement : MyScriptMonoBehaviour
{
    [SerializeField] private List<Transform> waypoints;
    [SerializeField] public float moveSpeed = 5f;
    [SerializeField] protected float rotateSpeed = 360f;
    [SerializeField] protected Transform holderPoint;

    private int currentWaypointIndex = 0;

    protected virtual List<Transform> PointMovement { get; }


    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadHolderPoint();
    }

    protected virtual void LoadHolderPoint()
    {
        if ( this.holderPoint != null ) { return; }
        else{ this.holderPoint = transform.parent.Find("HolderPoint"); }
    }
    protected override void Start()
    {
        LoadPointIndex();
    }
    protected virtual void LoadPointIndex()
    {
        waypoints = this.PointMovement;
        if (waypoints.Count > 0)
        {
            transform.position = waypoints[0].position;
        }
    }

    protected virtual void FixedUpdate()
    {
        CheckPos();
        AnimalMoving();
    }
    protected virtual void CheckPos() { }
    protected virtual void AnimalMoving()
    {
        if (waypoints.Count == 0)
        {
            return;
        }

        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].position, moveSpeed * Time.deltaTime);

        Vector3 directionToTarget = waypoints[currentWaypointIndex].position - transform.position;
        if (directionToTarget != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(directionToTarget);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation,rotateSpeed);
        }
        if (transform.position == waypoints[currentWaypointIndex].position)
        {
            currentWaypointIndex++;
            if (currentWaypointIndex >= waypoints.Count)
            {
                currentWaypointIndex = 0;
            }
        }
    }

}
