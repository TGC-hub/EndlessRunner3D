
using UnityEngine;

public class ParticleManager : MyScriptMonoBehaviour
{
    private static ParticleManager instance;
    public static ParticleManager Instance {  get { return instance; } }

    [SerializeField] protected ParticleSpawner particleSpawner;

    protected override void Awake()
    {
        base.Awake();
        if (ParticleManager.instance != null) Debug.LogError("Only 1 ParticleManager allow to exist");
        ParticleManager.instance = this;
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadParticleSpawner();
    }

    protected virtual void LoadParticleSpawner()
    {
        if (this.particleSpawner != null) { return; }
        else
        {
            this.particleSpawner = GetComponent<ParticleSpawner>();
        }
    }



    public virtual void Spawning(string prefabName)
    {
            Vector3 offset = new Vector3 (0, 0.5f, 0);
            Vector3 pos = LoadCharacter.Instance.Player.position + offset;
            Quaternion rot = LoadCharacter.Instance.Player.rotation;
            Transform obj = this.particleSpawner.Spawn(prefabName, pos, rot);
            obj.gameObject.SetActive(true);
    }



}
