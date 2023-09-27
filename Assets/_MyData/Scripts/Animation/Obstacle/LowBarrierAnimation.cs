
using UnityEngine;

public class LowBarrierAnimation : AnimationObstacle
{
    protected int isLowBarrierDeath;

    protected override void Start()
    {
        base.Start();
        isLowBarrierDeath = Animator.StringToHash("LowBarrier");
    }

    protected override void ActivateFeature()
    {
        animator.SetBool(isLowBarrierDeath, true);
    }

    protected override void StopActivateFeature()
    {
        animator.SetBool(isLowBarrierDeath, false);
    }
}
