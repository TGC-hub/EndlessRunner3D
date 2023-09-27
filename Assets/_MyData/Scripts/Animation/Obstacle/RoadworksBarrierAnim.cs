
using UnityEngine;

public class RoadworksBarrierAnim : AnimationObstacle
{
    protected int isRoadWorkDeath;

    protected override void Start()
    {
        base.Start();
        isRoadWorkDeath = Animator.StringToHash("RoadWork");
    }

    protected override void ActivateFeature()
    {
        animator.SetBool(isRoadWorkDeath, true);
    }

    protected override void StopActivateFeature()
    {
        animator.SetBool(isRoadWorkDeath, false);
    }
}
