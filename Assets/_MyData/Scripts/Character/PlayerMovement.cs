
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float startSpeed = 5f;
    [SerializeField] private float endSpeed = 20f;
    [SerializeField] private float duration = 60f; 

    private float currentSpeed;
    private float timeElapsed;
    public float logicGameSpeed = 1;
    float t;
    private void Start()
    {
        this.currentSpeed = startSpeed;
        this.timeElapsed = 0f;
        ObserverManager.Instance.CharacterOP.CharacterDeath += StateDeath;
        ObserverManager.Instance.ButtonEventOP.ButtonPause += LogicGamePause;
        ObserverManager.Instance.ButtonEventOP.ButtonPlay += LogicGamePlay;
    }

    protected virtual void FixedUpdate()
    {
        SetSpeed();
        MovementZ();
    }

    protected virtual void SetSpeed()
    {
        this.timeElapsed += Time.fixedDeltaTime;

        if (timeElapsed < duration)
        {
            t = timeElapsed / duration;
            currentSpeed = Mathf.Lerp(startSpeed, endSpeed, t);
        }
    }

    protected virtual void MovementZ()
    {
        transform.Translate(Vector3.forward * currentSpeed * logicGameSpeed * Time.fixedDeltaTime, Space.World);
    }


    protected virtual void StateDeath()
    {
        logicGameSpeed = 0;
    }

    protected virtual void LogicGamePause()
    {
        logicGameSpeed = 0;
    }

    protected virtual void LogicGamePlay()
    {
        logicGameSpeed = 1;
    }

}
