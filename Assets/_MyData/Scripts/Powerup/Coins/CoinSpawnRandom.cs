
using UnityEngine;

public class CoinSpawnRandom : SpawnerRandom
{
    [Header("Coin Random")]
    [SerializeField] protected CoinSpawnerCtrl coinSpawnerCtrl;
    [SerializeField] protected int currenRanPoint = 0;
    protected override void LoadCtrl()
    {
        if (this.coinSpawnerCtrl != null) { return; }
        else
        {
            this.coinSpawnerCtrl = GetComponent<CoinSpawnerCtrl>();
        }
    }
    Transform ranPoint;

    protected override void Start()
    {
        base.Start();
        ranPoint = this.coinSpawnerCtrl.SpawnPoints.GetRandom();
    }
    protected override void CreateSpawner()
    {
        base.CreateSpawner();
        if(ranPoint == null) { ranPoint = this.coinSpawnerCtrl.SpawnPoints.GetRandom(); }
        else
        {
            currenRanPoint += 1;
            if (this.currenRanPoint <= 2) {}
            else
            {
                this.randomTimer = 0;
                ranPoint = this.coinSpawnerCtrl.SpawnPoints.GetRandom();
                currenRanPoint = 0;
            }
        }
        Vector3 pos = ranPoint.position;
        Quaternion rot = transform.rotation;
        Transform prefab = this.coinSpawnerCtrl.CoinsSpawn.RandomPrefab();
        Transform obj = this.coinSpawnerCtrl.CoinsSpawn.Spawn(prefab, pos, rot);
        obj.gameObject.SetActive(true);
    }
    
}
