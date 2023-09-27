
using UnityEngine;

public class CoinReceiverByItem : MyScriptMonoBehaviour
{
    [SerializeField] protected  float magnetForce = 30f;

    private bool isActiveSuction = false;
    
    protected override void Start()
    {
        base.Start();
        ObserverManager.Instance.CollectorEventOP.CollectItemMagnet += SetActiveSuction;
        ObserverManager.Instance.CollectorEventOP.StopMagnet += StopMagnet;
    }

    protected virtual void StopMagnet()
    {
        isActiveSuction = false;
    }
    protected virtual void SetActiveSuction()
    {
        isActiveSuction = true;
    }

    private void FixedUpdate()
    {
        if (isActiveSuction == true)
        {
            float distance = Vector3.Distance(transform.parent.position, LoadCharacter.Instance.Player.position);
                if (distance < 10f && transform.parent.position.z > LoadCharacter.Instance.Player.position.z)
                {
                    transform.parent.position = Vector3.MoveTowards(transform.parent.position, LoadCharacter.Instance.Player.position, magnetForce * Time.fixedDeltaTime);
                }
        }
        else { return; }
    }

}
