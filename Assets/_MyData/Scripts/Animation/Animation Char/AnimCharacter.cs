using UnityEngine;

public class AnimCharacter : MonoBehaviour
{
  
    private Animator m_Animator;
    [SerializeField] private Transform player;

    private int runningArcHash;
    private int valuetArcHash;

    private int stateJumpHash;
    private int stateSlideHash;
    private int stateHitHash;
    private void Start()
    {
        m_Animator = GetComponent<Animator>();

        runningArcHash = Animator.StringToHash("StateRunningArc");
        valuetArcHash = Animator.StringToHash("RunningArc");

        stateJumpHash = Animator.StringToHash("StateJump");
        stateSlideHash = Animator.StringToHash("StateSlide");

        stateHitHash = Animator.StringToHash("IsHit");

        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        ObserverManager.Instance.ButtonEventOP.ButtonPause += LogicGamePause;
        ObserverManager.Instance.ButtonEventOP.ButtonPlay += LogicGamePlay;

    }

    protected virtual void LogicGamePause()
    {
        m_Animator.speed = 0;
    }

    protected virtual void LogicGamePlay()
    {
        m_Animator.speed = 1;
    }
    private void Update()
    {
        StateRunningArc();
        StateJump();
        StateSlide();
        StateHit();
    }

    protected virtual void StateRunningArc()
    {

        if (InputManager.Instance.ValueKeycode == 0 || player.position.x == -1.5f || player.position.x == 1.5f)
        {
            m_Animator.SetBool(runningArcHash, false);
        }
        else
        {
            if(PlayerManager.Instance.Checker.IsGround)
            {
                m_Animator.SetBool(runningArcHash, true);
                m_Animator.SetFloat(valuetArcHash, InputManager.Instance.ValueKeycode);
            }
        }
    }


    protected virtual void StateJump()
    {
            if (!PlayerManager.Instance.Checker.IsGround && player.position.y > 0)
            {
                m_Animator.SetBool(stateJumpHash, true);
            }
            else
            {
                m_Animator.SetBool(stateJumpHash, false);
            }
    }

    protected virtual void StateSlide()
    {
        if (PlayerManager.Instance.Checker.IsGround && InputManager.Instance.ScrollDelta == -1)
        {
            m_Animator.SetBool(stateSlideHash, true);
        }
        else
        {
            m_Animator.SetBool(stateSlideHash, false);
        }
    }

    protected virtual void StateHit()
    {
        m_Animator.SetFloat(stateHitHash, PlayerManager.Instance.SenderState.IsDead);
    }
}
