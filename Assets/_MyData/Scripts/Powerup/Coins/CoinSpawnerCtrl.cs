
using UnityEngine;

public class CoinSpawnerCtrl : SpawnerCtrl
{
    [SerializeField] protected CoinsSpawn coinsSpawn;
    public CoinsSpawn CoinsSpawn { get => coinsSpawn; }

    [SerializeField] protected CoinSpawnPoints spawnPoints;
    public CoinSpawnPoints SpawnPoints { get => spawnPoints; }


    protected override void LoadSpawner()
    {
        if (this.coinsSpawn != null) { return; }
        else
        {
            this.coinsSpawn = GetComponent<CoinsSpawn>();
        }
    }

    protected override void LoadSpawnPoints()
    {
        if (this.spawnPoints != null) { return; }
        else
        {
            this.spawnPoints = Transform.FindObjectOfType<CoinSpawnPoints>();
            Debug.Log(transform.name + ": LoadSpawnPoints", gameObject);
        }
    }

}
