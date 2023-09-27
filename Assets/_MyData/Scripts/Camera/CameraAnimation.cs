using System.Collections;
using UnityEngine;


public class CameraAnimation : MonoBehaviour
{
    [SerializeField] protected Animator m_Animator;
    protected int shakeHash;
    protected int startHash;

    protected bool isCameraFinished = false;

    private void Awake()
    {
        m_Animator = GetComponent<Animator>();
        shakeHash = Animator.StringToHash("Shaking");
        startHash = Animator.StringToHash("StartCamera");
    }
    protected virtual void Start()
    {
        ObserverManager.Instance.ObstacleEventOP.ObstacleTrigger += ActiveShake;
    }

    private void LateUpdate()
    {
        StartAnim();
    }

    protected virtual void StartAnim()
    {
        if (isCameraFinished == false)
        {
            m_Animator.SetBool(startHash, true);
            isCameraFinished = true;
        }
        else
        {
            m_Animator.SetBool(startHash, false);
        }
    }
    protected virtual void ActiveShake()
    {
        m_Animator.SetBool(shakeHash, true);
        StartCoroutine(WaitForSecond());
    }

    IEnumerator WaitForSecond()
    {
        yield return new WaitForSeconds(0.75f);
        m_Animator.SetBool(shakeHash, false);
    }

}
