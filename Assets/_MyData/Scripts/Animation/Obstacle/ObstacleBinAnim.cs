
using UnityEngine;

public class ObstacleBinAnim : AnimationObstacle
{
    protected int isBinDeath;

    protected override void Start()
    {
        base.Start();
        isBinDeath = Animator.StringToHash("Bin");
    }

    protected override void ActivateFeature()
    {
        animator.SetBool(isBinDeath, true);
    }

    protected override void StopActivateFeature()
    {
        animator.SetBool(isBinDeath, false);
    }
}
