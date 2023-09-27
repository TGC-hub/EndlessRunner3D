
using UnityEngine;

public class AnimalsSpawnRandom : SpawnerRandom
{
    [Header("Animal Random")]
    [SerializeField] protected AnimalsSpawnCtrl animalSpawnerCtrl;

    protected override void LoadCtrl()
    {
        if (this.animalSpawnerCtrl != null) { return; }
        else
        {
            this.animalSpawnerCtrl = GetComponent<AnimalsSpawnCtrl>();
        }
    }

    protected override void CreateSpawner()
    {
        base.CreateSpawner();
        Transform ranPoint = this.animalSpawnerCtrl.SpawnPoints.GetRandom();
        Vector3 pos = ranPoint.position;
        Quaternion rot = transform.rotation;

        Transform prefab = this.animalSpawnerCtrl.AnimalSpawner.RandomPrefab();
        Transform obj = this.animalSpawnerCtrl.AnimalSpawner.Spawn(prefab, pos, rot);
        obj.gameObject.SetActive(true);
    }

}
