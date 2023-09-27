
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SliderMusicVolume : MonoBehaviour
{
    [SerializeField] protected AudioMixer audioMixer;
    [SerializeField] protected Slider slider;

    private void Start()
    {
        if (PlayerPrefs.HasKey("MusicVolume"))
        {
            LoadVolume();
        }
        else
        {
            SetVolumeMusic();
        }
    }

    public virtual void SetVolumeMusic()
    {
        float volume = slider.value;
        audioMixer.SetFloat("Music", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("MusicVolume", volume);
    }

    protected void LoadVolume()
    {
        slider.value = PlayerPrefs.GetFloat("MusicVolume");
        SetVolumeMusic();
    }
}
