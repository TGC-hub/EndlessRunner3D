
using UnityEngine;


public abstract class SpawnerRandom : MyScriptMonoBehaviour
{
    [Header("Spawner Random")]
    [SerializeField] protected float randomDelay = 1f;
    [SerializeField] protected float randomTimer = 0f;
    [SerializeField] protected float randomLimit = 9f;

    protected bool logicGame = true;
    protected override void Start()
    {
        base.Start();
        ObserverManager.Instance.ButtonEventOP.ButtonPause += LogicGamePause;
        ObserverManager.Instance.ButtonEventOP.ButtonPlay += LogicGamePlay;
    }

    protected virtual void LogicGamePause()
    {
        logicGame = false;
    }

    protected virtual void LogicGamePlay()
    {
        logicGame = true;
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadCtrl();
    }

    protected virtual void LoadCtrl() { }

    protected virtual void FixedUpdate()
    {
        this. Spawning();
    }

    protected virtual void Spawning()
    {
        if (logicGame == false) { return; }
        this.randomTimer += Time.fixedDeltaTime;
        if (this.randomTimer < this.randomDelay) return;
        this.randomTimer = 0;
        CreateSpawner();
    }

    protected virtual void CreateSpawner() { }
}
