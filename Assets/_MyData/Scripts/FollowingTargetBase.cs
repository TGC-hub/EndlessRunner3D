
using UnityEngine;

public class FollowingTargetBase : MyScriptMonoBehaviour
{
    public Transform target; 
    public  float smoothSpeed = 0.125f; 
    public Vector3 offset;

     Vector3 desiredPositionss;
     Vector3 smoothedPosition;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    protected virtual void LateUpdate()
    {
        desiredPositionss = target.position + offset; 
        smoothedPosition = Vector3.Lerp(transform.position, desiredPositionss, smoothSpeed);
        smoothedPosition.x = transform.position.x;
        smoothedPosition.y = transform.position.y;
        transform.position = smoothedPosition;
    }
}
