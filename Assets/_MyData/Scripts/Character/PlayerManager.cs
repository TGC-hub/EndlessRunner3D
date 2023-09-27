
using UnityEngine;

public class PlayerManager : MyScriptMonoBehaviour
{

    private static PlayerManager instance;
    public static PlayerManager Instance { get => instance; }

    [SerializeField] protected PlayerChecker checker;
    public PlayerChecker Checker { get => checker;}

    [SerializeField] protected PlayerSenderState senderState;
    public PlayerSenderState SenderState { get => senderState; }

    [SerializeField] protected CollectorOP collector;
    public CollectorOP Collector { get => collector; }

    [SerializeField] protected PlayerMovement playerMovement;
    public PlayerMovement PlayerMovement { get => playerMovement; }
    protected override void Awake()
    {
        base.Awake();
        if (PlayerManager.instance != null) Debug.LogError("Only 1 PlayerManager allow to exist");
        PlayerManager.instance = this;
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadChecker();
        LoadSenderState();
        LoadCollector();
        LoadPlayerMovement();
    }
    protected virtual void LoadPlayerMovement()
    {
        if (playerMovement != null) { return; }
        playerMovement = GetComponent<PlayerMovement>();
    }

    protected virtual void LoadChecker()
    {
        if (this.checker != null) { return; }
        else
        {
            this.checker = Transform.FindObjectOfType<PlayerChecker>();
        }

    }

    protected virtual void LoadSenderState()
    {
        if (this.senderState != null) { return; }
        else
        {
            this.senderState = Transform.FindObjectOfType<PlayerSenderState>();
        }

    }

    protected virtual void LoadCollector()
    {
        if (this.collector != null) { return; }
        else
        {
            this.collector = Transform.FindObjectOfType<CollectorOP>();
        }
    }

}
