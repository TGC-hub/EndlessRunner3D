
using UnityEngine;

public class ObserverManager : MyScriptMonoBehaviour
{
    private static ObserverManager instance;
    public static ObserverManager Instance { get { return instance; } }

    [SerializeField] protected CollectorEventOP collectorEventOP;
    public CollectorEventOP CollectorEventOP { get => collectorEventOP; }

    [SerializeField] protected ObstacleEventOP obstacleEventOP;
    public ObstacleEventOP ObstacleEventOP { get => obstacleEventOP; }

    [SerializeField] protected PointFishBoneOP pointFishBoneOP;
    public PointFishBoneOP PointFishBoneOP { get => pointFishBoneOP; }

    [SerializeField] protected CollectorOP collectorOP;
    public CollectorOP CollectorOP { get => collectorOP; }

    [SerializeField] protected ButtonEventOP buttonEventOP;
    public ButtonEventOP ButtonEventOP { get => buttonEventOP; }

    [SerializeField] protected CharacterOP characterOP;
    public CharacterOP CharacterOP { get => characterOP; }


    protected override void Awake()
    {
        base.Awake();
        if (ObserverManager.instance != null) Debug.LogError("Only 1 ObserverCtrl allow to exist");
        ObserverManager.instance = this;
    }


    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadCollectEvent();
        LoadObstaclevent();
        LoadPointFish();
        LoadCollector();
        LoadButtonEvent();
        LoadCharacterOP();
    }
    protected virtual void LoadCharacterOP()
    {
        if (this.characterOP != null) { return; }
        else
        {
            this.characterOP = GetComponent<CharacterOP>();
        }
    }

    protected virtual void LoadButtonEvent()
    {
        if (this.buttonEventOP != null) { return; }
        else
        {
            this.buttonEventOP = this.GetComponent<ButtonEventOP>();
        }
    }

    protected virtual void LoadCollector()
    {
        if (this.collectorOP != null) { return; }
        else
        {
            this.collectorOP = GameObject.FindGameObjectWithTag("ReceiverItem").GetComponent<CollectorOP>();
        }
    }

    protected virtual void LoadPointFish()
    {
        if (this.pointFishBoneOP != null) { return; }
        else
        {
            this.pointFishBoneOP = this.GetComponent<PointFishBoneOP>();
        }
    }

    protected virtual void LoadCollectEvent()
    {
        if (this.collectorEventOP != null) { return; }
        else
        {
            this.collectorEventOP = this.GetComponent<CollectorEventOP>();
        }
    }

    protected virtual void LoadObstaclevent()
    {
        if (this.obstacleEventOP != null) { return; }
        else
        {
            this.obstacleEventOP = this.GetComponent<ObstacleEventOP>();
        }
    }

}
