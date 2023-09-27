using System.Collections;
using UnityEngine;

public class CameraMenu : MonoBehaviour
{
    private Animator animator;
    private bool isActive = true;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        StartCoroutine(PlayAnimationOnce());
    }
    protected virtual void Active()
    {
        if (isActive == false) { animator.SetBool("Active", false); }
        else { animator.SetBool("Active", true); isActive = false; }
    }
    private IEnumerator PlayAnimationOnce()
    {
        Active();
        yield return new WaitForSeconds(1.2f);
        Active();
    }
}
