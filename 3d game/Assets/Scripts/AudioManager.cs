using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    [SerializeField] private AudioSource audioBG;
    [SerializeField] private AudioSource audioSFX;
    [SerializeField] private AudioMixer audioMixer;


    public AudioClip Pickup;
    public AudioClip bgmusic;

    public void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            instance = this;
        }
        else
        { 
            instance = this;
        }
        //loadVolume();
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        audioMixer.SetFloat("Master", Mathf.Lerp(-80f, 0f, PlayerPrefs.GetFloat("masterVolume", 1f)));
        audioMixer.SetFloat("BG", Mathf.Lerp(-80f, 0f, PlayerPrefs.GetFloat("bgVolume", 1f)));
        audioMixer.SetFloat("SFX", Mathf.Lerp(-80f, 0f, PlayerPrefs.GetFloat("sfxVolume", 1f)));
        audioBG.clip = bgmusic;
        audioBG.Play();
    }

    public void pickupSFX(AudioClip Pickup)
    { 
        audioSFX.PlayOneShot(Pickup);
    }

    public void playBG(AudioClip bgmusic)
    {
        audioBG.PlayOneShot(bgmusic);
    }
    public void loadVolume() 
    {
        audioMixer.SetFloat("Master", Mathf.Lerp(-80f, 0f, PlayerPrefs.GetFloat("masterVolume", 1f)));
        audioMixer.SetFloat("BG", Mathf.Lerp(-80f, 0f, PlayerPrefs.GetFloat("bgVolume", 1f)));
        audioMixer.SetFloat("SFX", Mathf.Lerp(-80f, 0f, PlayerPrefs.GetFloat("sfxVolume", 1f)));
    }

    public void SaveVolume(float volume)
    {
        audioMixer.SetFloat("Master", volume);
        PlayerPrefs.SetFloat("Master", volume);
    }
}
