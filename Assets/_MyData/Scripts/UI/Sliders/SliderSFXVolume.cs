using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SliderSFXVolume : MonoBehaviour
{
    [SerializeField] protected AudioMixer audioMixer;
    [SerializeField] protected Slider slider;

    private void Start()
    {
        if (PlayerPrefs.HasKey("SFXVolume"))
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
        audioMixer.SetFloat("SFX", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("SFXVolume", volume);
    }

    protected void LoadVolume()
    {
        slider.value = PlayerPrefs.GetFloat("SFXVolume");
        SetVolumeMusic();
    }
}
