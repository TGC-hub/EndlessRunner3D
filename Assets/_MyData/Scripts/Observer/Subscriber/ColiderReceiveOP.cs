using UnityEngine;

public class ColiderReceiveOP : MyScriptMonoBehaviour
{
    [SerializeField] protected Transform player;
    [SerializeField] protected Collider _collider;

    private bool isActiveInvincivle = false;
    protected override void Start()
    {
        base.Start();
        ObserverManager.Instance.CollectorEventOP.CollectItemInvincible += SetActiveInvinvible;
        ObserverManager.Instance.CollectorEventOP.StopInvincible += StopInvincible;
        
    }

    protected virtual void StopInvincible()
    {
        isActiveInvincivle = false;
    }
    protected virtual void SetActiveInvinvible()
    {
        isActiveInvincivle = true;
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadPlayer();
        LoadCollider();
    }

    protected virtual void LoadPlayer()
    {
        if (player != null) { return; }
        else
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }

    protected virtual void LoadCollider()
    {
        if (_collider != null) { return; }
        else
        {
            _collider = transform.GetComponent<Collider>();  
        }
    }


    private void Update()
    {
        if (isActiveInvincivle)
        {
            _collider.enabled = false;
        }
        else
        {
            _collider.enabled = true;
        }
    }

}
