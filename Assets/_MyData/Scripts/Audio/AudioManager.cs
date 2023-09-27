using System.Collections;
using UnityEngine;

public class AudioManager : MyScriptMonoBehaviour
{
    
    private static AudioManager instance;
    public static AudioManager Instance { get { return instance; } }

    public AudioSource audioSource;

    protected override void Awake()
    {
        base.Awake();
        if (AudioManager.instance != null) { Debug.LogError("Only 1 AudioManager allow to exist"); }
        else { AudioManager.instance = this; }
    }


    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadAudioSource();
    }

    protected virtual void LoadAudioSource()
    {
        if (audioSource != null) { return; }
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySoundOneShot(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }


    public void PlaySoundLoop(AudioClip clip , float loopSound)
    {
        audioSource.clip = clip;
        StartCoroutine(PlayAudioLoop(loopSound));
    }
    private IEnumerator PlayAudioLoop(float loopSound)
    {
            
        audioSource.Play();
        yield return new WaitForSeconds(loopSound);
        audioSource.Stop();
    }
}
