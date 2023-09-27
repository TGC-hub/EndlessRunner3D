using System.Collections.Generic;
using UnityEngine;

public class SpawnCar : Spawner
{
    private static SpawnCar instance;
    public static SpawnCar Instance => instance;

    [SerializeField] protected List<Transform> listCar = new List<Transform>();

    protected override void Awake()
    {
        base.Awake();
        if (SpawnCar.instance != null) Debug.LogError("Only 1 SpawnCar allow to exist");
        SpawnCar.instance = this;
    }

    protected override void Start()
    {
        base.Start();
        SelectCar();
    }

    protected virtual void SelectCar()
    {
        foreach (Transform prefab in prefabs)
        {
            if (prefab.name != "Car05")
            {
                listCar.Add(prefab);
            }
        }
    }

    public override Transform RandomPrefab()
    {
        int rand = Random.Range(0, this.listCar.Count);
        return this.listCar[rand];
    }

}
