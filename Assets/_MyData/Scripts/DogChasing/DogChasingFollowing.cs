
using UnityEngine;

public class DogChasingFollowing : FollowingTargetBase
{
    protected override void LateUpdate()
    {
        Vector3 desiredPositions = target.position + offset;
        transform.position = desiredPositions;
    }
}
