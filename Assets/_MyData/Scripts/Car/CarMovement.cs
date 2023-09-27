
using UnityEngine;

public class CarMovement : MyScriptMonoBehaviour
{
    public float moveSpeed = 10f;
    private float logicGameSpeed = 1;

    protected override void Start()
    {
        base.Start();
        ObserverManager.Instance.ButtonEventOP.ButtonPause += LogicGamePause;
        ObserverManager.Instance.ButtonEventOP.ButtonPlay += LogicGamePlay;
    }

    private void LogicGamePause()
    {
        logicGameSpeed = 0;
    }
    private void LogicGamePlay()
    {
        logicGameSpeed = 1;
    }
    protected virtual void FixedUpdate()
    {
        SetMoving();
    }

    protected virtual void SetMoving()
    {

        switch (this.transform.rotation.eulerAngles.y)
        {
            case 90:
                Vector3 v90 = Vector3.right;
                Moving(v90);
                break;
            case 270:
                Vector3 _v90 = Vector3.left;
                Moving(_v90);
                break;
            case 180:
                Vector3 v180 = Vector3.back;
                Moving(v180);
                break;
            case 0:
                Vector3 v0 = Vector3.forward;
                Moving(v0);
                break;

        }
    }

    protected virtual void Moving(Vector3 vector3)
    {
        this.transform.Translate(vector3 * moveSpeed * logicGameSpeed * Time.deltaTime,Space.World);
    }

}
