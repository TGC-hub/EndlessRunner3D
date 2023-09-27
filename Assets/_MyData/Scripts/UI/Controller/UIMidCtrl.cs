
using UnityEngine;

public class UIMidCtrl : MyScriptMonoBehaviour
{
    private static UIMidCtrl instance;
    public static UIMidCtrl Intance { get { return instance; } }

    [SerializeField] protected PanelPauseAppear panelPause;
    public PanelPauseAppear PanelPause { get { return panelPause; } }

    [SerializeField] protected PanelDeathAppear panelDeath;
    public PanelDeathAppear PanelDeath { get { return panelDeath; } }

    [SerializeField] protected PanelTutorialAppear panelTutorial;
    public PanelTutorialAppear PanelTutorial { get { return panelTutorial; } }

    private bool isDeath = false;
    protected override void Awake()
    {
        base.Awake();
        if (UIMidCtrl.instance != null) Debug.LogError("Only 1 UITopRightCtrl allow to exist");
        UIMidCtrl.instance = this;
    }

    protected override void Start()
    {
        base.Start();
        isDeath = false;
        ObserverManager.Instance.CharacterOP.CharacterDeath += IsDeath;
        panelPause.gameObject.SetActive(false);
    }

    protected virtual void IsDeath()
    {
        if (isDeath == true) { return; }
        panelDeath.Appear();
        isDeath = true;
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadPanelPause();
        LoadPanelDeath();
        LoadPanelTutorial();
    }

    protected virtual void LoadPanelDeath()
    {
        if (panelDeath != null) { return; }
        panelDeath = GetComponentInChildren<PanelDeathAppear>();
    }

    protected virtual void LoadPanelPause()
    {
        if(panelPause != null) { return; }
        panelPause = GetComponentInChildren<PanelPauseAppear>();
    }

    protected virtual void LoadPanelTutorial()
    {
        if (panelTutorial != null) { return; }
        panelTutorial = GetComponentInChildren<PanelTutorialAppear>();
    }
}
