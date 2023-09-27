
using UnityEngine;

public class OtherSpawnRandom : SpawnerRandom
{
    [Header("Other Random")]
    [SerializeField] protected OtherSpawnerCtrl otherSpawnerCtrl;

    protected override void LoadCtrl()
    {
        if (this.otherSpawnerCtrl != null) { return; }
        else
        {
            this.otherSpawnerCtrl = GetComponent<OtherSpawnerCtrl>();
        }
    }

    protected override void CreateSpawner()
    {
        base.CreateSpawner();
        Transform ranPoint = this.otherSpawnerCtrl.SpawnPoints.GetRandom();
        Vector3 pos = ranPoint.position;
        Quaternion rot = transform.rotation;

        Transform prefab = this.otherSpawnerCtrl.OtherSpawner.RandomPrefab();
        Transform obj = this.otherSpawnerCtrl.OtherSpawner.Spawn(prefab, pos, rot);
        obj.gameObject.SetActive(true);
    }

}
