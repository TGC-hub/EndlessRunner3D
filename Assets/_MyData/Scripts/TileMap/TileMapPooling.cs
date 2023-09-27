
using UnityEngine;

public class TileMapPooling : MyScriptMonoBehaviour
{
    private float spawnZ = 0.0f;
    private const float tileLength = 27.0f;
    private const float safeZone = 36.0f;
    private const int amnTilesOnScreen = 7;

    Transform obj;
    Vector3 tileMapPos;
    Quaternion rot;
    Transform prefab;
    protected override void Start()
    {
        for (int i = 0; i < amnTilesOnScreen; i++)
        {
            SpawnTiles();
        }
    }

    protected virtual void FixedUpdate()
    {
        if (LoadCharacter.Instance.Player.position.z - safeZone > (spawnZ - amnTilesOnScreen * tileLength))
        {
            SpawnTiles();
        }
    }

    protected virtual void SpawnTiles()
    {
        tileMapPos = transform.position;
        rot = transform.rotation;
        prefab = TileMapSpawner.Instance.RandomPrefab();
        obj = TileMapSpawner.Instance.Spawn(prefab, tileMapPos, rot);
        obj.position = Vector3.forward * spawnZ;
        spawnZ += tileLength;
        obj.gameObject.SetActive(true);
    }


}
