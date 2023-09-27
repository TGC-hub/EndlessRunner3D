
using UnityEngine;

public class DogCtrl : MyScriptMonoBehaviour
{
    [SerializeField] protected DogTrap dogTrap;
    public DogTrap DogTrap { get => dogTrap; }

    [SerializeField] protected DogTriggerActive dogTriggerActive;
    public DogTriggerActive DogTriggerActive { get => dogTriggerActive; }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadSpawner();
        this.LoadSpawnPoints();
    }

    protected virtual void LoadSpawner()
    {
        if (this.dogTrap != null) { return; }
        else
        {
            this.dogTrap = transform.GetComponentInChildren<DogTrap>();
        }
    }

    protected virtual void LoadSpawnPoints()
    {
        if (this.dogTriggerActive != null) { return; }
        else
        {
            this.dogTriggerActive = transform.GetComponentInChildren<DogTriggerActive>();
        }
    }
}
