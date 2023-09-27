
using UnityEngine;

public class WheelyBinAnim : AnimationObstacle
{
    protected int isWheelyBinDeath;

    protected override void Start()
    {
        base.Start();
        isWheelyBinDeath = Animator.StringToHash("WheelyBin");
    }

    protected override void ActivateFeature()
    {
        animator.SetBool(isWheelyBinDeath, true);
    }

    protected override void StopActivateFeature()
    {
        animator.SetBool(isWheelyBinDeath, false);
    }
}
