using UnityEngine;

public class AudioClipManager : MonoBehaviour
{
    private static AudioClipManager instance;
    public static AudioClipManager Instance { get { return instance; } }

    [Header("Sound Item")]
    [Space(5)]
    [SerializeField] public AudioClip eatFishBone;
    [SerializeField] public AudioClip powerUpCollection;
    [SerializeField] public AudioClip magnet;
    [SerializeField] public AudioClip invincible;
    [SerializeField] public AudioClip mutil;

    [Header("Sound Player")]
    [Space(5)]
    [SerializeField] public AudioClip footsteps;
    [SerializeField] public AudioClip slide;
    [SerializeField] public AudioClip jump;
    [SerializeField] public AudioClip slide2;

    [Header("Sound Dog")]
    [Space(5)]
    [SerializeField] public AudioClip soundDog1;
    [SerializeField] public AudioClip soundDog2;
    [SerializeField] public AudioClip soundDogHit;

    [Header("Sound Car")]
    [Space(5)]
    [SerializeField] public AudioClip carDriving;
    [SerializeField] public AudioClip carBipBip;

    [Header("Sound Obstacle")]
    [Space(5)]
    [SerializeField] public AudioClip woodenBarrier;
    [SerializeField] public AudioClip wheelieBin;
    [SerializeField] public AudioClip trashCan;
    [SerializeField] public AudioClip trafficCone;

    [Header("Sound Death")]
    [Space(5)]
    [SerializeField] public AudioClip death;
    [SerializeField] public AudioClip carAccident;

    [Header("SoundButton")]
    [Space(5)]
    [SerializeField] public AudioClip button;

    private void Awake()
    {
        if (AudioClipManager.instance != null) Debug.LogError("Only 1 AudioClipManager allow to exist");
        AudioClipManager.instance = this;
    }
}
