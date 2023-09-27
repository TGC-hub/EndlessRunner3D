
using UnityEngine;

public class BarrierSpawnRandom : SpawnerRandom
{
    [Header("Barrier Random")]
    [SerializeField] protected BarrierSpawnerCtrl barrierSpawnerCtrl;

    protected override void LoadCtrl()
    {
        if (this.barrierSpawnerCtrl != null) { return; }
        else
        {
            this.barrierSpawnerCtrl = GetComponent<BarrierSpawnerCtrl>();
        }
    }

    protected override void CreateSpawner()
    {
        base.CreateSpawner();
        Transform ranPoint = this.barrierSpawnerCtrl.SpawnPoints.GetRandom();
        Vector3 pos = ranPoint.position;
        Quaternion rot = transform.rotation;

        Transform prefab = this.barrierSpawnerCtrl.BarrierSpawner.RandomPrefab();
        Transform obj = this.barrierSpawnerCtrl.BarrierSpawner.Spawn(prefab, pos, rot);
        obj.gameObject.SetActive(true);
    }

}
