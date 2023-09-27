
using UnityEngine;

public class SpawnCarRight : SpawnCarPos
{
    [SerializeField] protected Transform pointSpawn;

    protected virtual void LoadPointSpawn()
    {
        if (pointSpawn != null) { return; }
        this.pointSpawn = transform.Find("PointSpawn");
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadPointSpawn();
    }
    protected override void SetSpawning()
    {
        Vector3 pos = pointSpawn.position;
        Quaternion rot = Quaternion.Euler(0f, 270f, 0f);
        Transform prefab = SpawnCar.Instance.RandomPrefab();
        Transform obj = SpawnCar.Instance.Spawn(prefab, pos, rot);
        obj.gameObject.SetActive(true);
    }

    protected override void ResetValue()
    {
        base.ResetValue();
        spawnInterval = 5f;
    }
}
