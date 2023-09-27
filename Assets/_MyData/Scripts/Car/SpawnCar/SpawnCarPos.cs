
using UnityEngine;

public class SpawnCarPos : MyScriptMonoBehaviour
{
    [SerializeField] protected float spawnInterval = 3f;
    float timer = 0f;
    private bool logicGame = true;

    protected override void Start()
    {
        base.Start();
        ObserverManager.Instance.ButtonEventOP.ButtonPause += LogicGamePause;
        ObserverManager.Instance.ButtonEventOP.ButtonPlay += LogicGamePlay;
    }

    protected void LogicGamePause()
    {
        logicGame = false;
    }

    protected void LogicGamePlay()
    {
        logicGame = true;
    }

    protected virtual void Update()
    {
        if(logicGame == false) { return; }
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            SetSpawning();
            timer = 0f;
        }
    }
    protected virtual void SetSpawning()
    {
    }

}
