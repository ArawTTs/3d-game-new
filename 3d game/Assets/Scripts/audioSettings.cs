using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class audioSettings : MonoBehaviour
{
    [SerializeField] AudioMixer audioMixer;
    [SerializeField] Slider masterSlider;
    [SerializeField] Slider BGslider;
    [SerializeField] Slider SFXslider;

    public void Awake()
    {
        masterSlider.value = PlayerPrefs.GetFloat("masterVolume", 1f);
        BGslider.value = PlayerPrefs.GetFloat("bgVolume", 1f);
        SFXslider.value = PlayerPrefs.GetFloat("sfxVolume", 1f);
    }

    public void SetBGVolume()
    {
        float Volume = BGslider.value;
        audioMixer.SetFloat("BG", Mathf.Lerp(-80f, 0f, Volume));
        PlayerPrefs.SetFloat("bgVolume", Volume);
    }

    public void SetSFXVolume()
    {
        float Volume = SFXslider.value;
        audioMixer.SetFloat("SFX", Mathf.Lerp(-80f, 0f, Volume));
        PlayerPrefs.SetFloat("sfxVolume", Volume);
    }

    public void SetMasterVolume()
    {
        float Volume = masterSlider.value;
        audioMixer.SetFloat("Master", Mathf.Lerp(-80f, 0f, Volume));
        PlayerPrefs.SetFloat("masterVolume", Volume);
    }
}
