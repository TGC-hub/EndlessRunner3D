using System.Collections;
using UnityEngine;

public class AnimationObstacle : EventActiveByCollider
{
    protected Animator animator;
    protected override void Start()
    {
        animator = GetComponent<Animator>();
    }

    protected override void OnTriggerExit(Collider other)
    {

    }

    protected override void OneActive()
    {
        base.OneActive();
        StartCoroutine(UpdateIsActive());
    }

    IEnumerator UpdateIsActive()
    {
        yield return new WaitForSeconds(2f);
        isActive = false;
    }



}
