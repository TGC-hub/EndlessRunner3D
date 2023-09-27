
using UnityEngine;

public class AnimalsSpawnCtrl : SpawnerCtrl
{
    [SerializeField] protected AnimalSpawner animalSpawner;
    public AnimalSpawner AnimalSpawner { get => animalSpawner; }

    [SerializeField] protected AnimalsSpawnPoint spawnPoints;
    public AnimalsSpawnPoint SpawnPoints { get => spawnPoints; }

    protected override void LoadSpawner()
    {
        if (this.animalSpawner != null) { return; }
        else
        {
            this.animalSpawner = GetComponent<AnimalSpawner>();
        }
    }

    protected override void LoadSpawnPoints()
    {
        if (this.spawnPoints != null) { return; }
        else
        {
            this.spawnPoints = Transform.FindObjectOfType<AnimalsSpawnPoint>();
            Debug.Log(transform.name + ": LoadSpawnPoints", gameObject);
        }
    }
}
