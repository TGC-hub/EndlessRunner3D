using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimColider : MonoBehaviour
{
    protected Animator animator;
    private int stateJumpHash;
    private int stateSlideHash;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void Start()
    {
        stateJumpHash = Animator.StringToHash("IsJump");
        stateSlideHash = Animator.StringToHash("IsSlide");
    }
    private void Update()
    {
        Jump();
        Slide();
    }

    protected void Jump()
    {
        if (!PlayerManager.Instance.Checker.IsGround && PlayerManager.Instance.transform.position.y > 0)
        {
            animator.SetBool(stateJumpHash, true);
        }
        else
        {
            animator.SetBool(stateJumpHash, false);
        }
    }

    protected void Slide()
    {
        if (PlayerManager.Instance.Checker.IsGround && InputManager.Instance.ScrollDelta == -1)
        {
            animator.SetBool(stateSlideHash, true);
        }
        else
        {
            animator.SetBool(stateSlideHash, false);
        }
    }
}
