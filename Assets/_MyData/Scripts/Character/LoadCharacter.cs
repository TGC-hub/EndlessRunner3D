
using UnityEngine;

public class LoadCharacter : MonoBehaviour
{
    private static LoadCharacter instance;
    public static LoadCharacter Instance { get { return instance; } }

    [SerializeField] private Transform player;
    public Transform Player { get { return player; } }

    private void Awake()
    {
        if (LoadCharacter.instance != null) Debug.LogError("Only 1 LoadCharacter allow to exist");
        LoadCharacter.instance = this;
    }

    private void Reset()
    {
        LoadTransformCharacter();
    }

    protected virtual void LoadTransformCharacter()
    {
        if (player != null) { return;  }
        player = this.transform;
    }
}
