using UnityEngine;

public class HightBarrierAnimation : AnimationObstacle
{
    protected int isHightBarrierDeath;

    protected override void Start()
    {
        base.Start();
        isHightBarrierDeath = Animator.StringToHash("HightBarrier");
    }

    protected override void ActivateFeature()
    {
        animator.SetBool(isHightBarrierDeath, true);
    }

    protected override void StopActivateFeature()
    {
        animator.SetBool(isHightBarrierDeath, false);
    }
}
