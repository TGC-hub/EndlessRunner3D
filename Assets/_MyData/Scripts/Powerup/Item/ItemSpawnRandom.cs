
using UnityEngine;

public class ItemSpawnRandom : SpawnerRandom
{
    [Header("Item Random")]
    [SerializeField] protected ItemSpawnerCtrl itemSpawnerCtrl;

    protected override void LoadCtrl()
    {
        if (this.itemSpawnerCtrl != null) { return; }
        else
        {
            this.itemSpawnerCtrl = GetComponent<ItemSpawnerCtrl>();
        }
    }

    protected override void CreateSpawner()
    {
        base.CreateSpawner();
        Transform ranPoint = this.itemSpawnerCtrl.SpawnPoints.GetRandom();
        Vector3 pos = ranPoint.position;
        Quaternion rot = transform.rotation;

        Transform prefab = this.itemSpawnerCtrl.ItemSpawner.RandomPrefab();
        Transform obj = this.itemSpawnerCtrl.ItemSpawner.Spawn(prefab, pos, rot);
        obj.gameObject.SetActive(true);
    }

}
