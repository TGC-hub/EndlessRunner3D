
using UnityEngine;

public class SpawnCarTSection : SpawnCarPos
{
    [SerializeField] protected SpawnCarPointRandom spawnCarPointRandom;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadSpawnCarPointRandom();
    }

    protected virtual void LoadSpawnCarPointRandom()
    {
        if (spawnCarPointRandom != null) { return; }
        this.spawnCarPointRandom = GetComponent<SpawnCarPointRandom>();
    }
    protected override void SetSpawning()
    {
        Transform ranPoint = this.spawnCarPointRandom.GetRandom();
        Vector3 pos = ranPoint.position;
        Quaternion rot = Quaternion.Euler(0f, 270f, 0f);
        Transform prefab = SpawnCar.Instance.GetPrefabByName("Car05");
        Transform obj = SpawnCar.Instance.Spawn(prefab, pos, rot);
        obj.gameObject.SetActive(true);
    }

    protected override void ResetValue()
    {
        base.ResetValue();
        spawnInterval = 5f;
    }
}
