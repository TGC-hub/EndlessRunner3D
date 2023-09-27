using System.Collections;
using UnityEngine;

public class DogChasingMove : MyScriptMonoBehaviour
{
    [SerializeField] protected Transform posA;
    [SerializeField] protected Transform posB;
    [SerializeField] protected  float moveSpeed = 3f;
    [SerializeField] protected  float returnDelay = 5f;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadPoint();
    }


    protected virtual void LoadPoint()
    {
        if (this.posB != null) { return; }
        else
        {
            this.posB = transform.parent.Find("PointB");
        }
        if(this.posA != null) { return; }
        else
        {
            this.posA = transform.parent.Find("PointA");
        }
    }

   protected virtual void FixedUpdate()
    {
        if(PlayerManager.Instance.SenderState.IsTriggerObstacle) 
        {
            StartCoroutine(MoveAndReturnRoutine());
        }
    }

    private IEnumerator MoveAndReturnRoutine()
    {
        
        while (Vector3.Distance(transform.position, posB.position) > 0.01f)
        {
            transform.position = Vector3.MoveTowards(transform.position, posB.position, moveSpeed * Time.fixedDeltaTime);
            yield return null;
        }

        yield return new WaitForSeconds(returnDelay);

        while (Vector3.Distance(transform.position, posA.position) > 0.01f)
        {
            transform.position = Vector3.MoveTowards(transform.position, posA.position, moveSpeed * Time.fixedDeltaTime);
            yield return null;
        }

    }

}
