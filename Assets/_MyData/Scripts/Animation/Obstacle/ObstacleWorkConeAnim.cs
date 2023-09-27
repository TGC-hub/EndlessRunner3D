
using UnityEngine;

public class ObstacleWorkConeAnim : AnimationObstacle
{
    protected int isWorkConeDeath;

    protected override void Start()
    {
        base.Start();
        isWorkConeDeath = Animator.StringToHash("WorkCone");
    }

    protected override void ActivateFeature()
    {
        animator.SetBool(isWorkConeDeath, true);
    }

    protected override void StopActivateFeature()
    {
        animator.SetBool(isWorkConeDeath, false);
    }
}
