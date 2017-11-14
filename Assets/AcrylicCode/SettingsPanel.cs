using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsPanel : MonoBehaviour
{
    //PUBLIC
    [Header("Sound Settings")]
    public AudioMixer audioMixer;
    public Slider sfxSlider;
    private string sfxVolTypeKey = "SFX Volume";
    public Slider musicSlider;
    private string musicVolTypeKey = "Music Volume";

    

    void Start()
    {
        //SFX Volume start
        sfxSlider.value = PlayerPrefs.GetFloat(sfxVolTypeKey);
        Slider_SetSFXVolume();
        //if (PlayerPrefs.HasKey(sfxVolTypeKey))
        //{
            
        //}
        //else
        //{
        //    sfxSlider.value = 1f;
        //}

        //Music Volume start
        musicSlider.value = PlayerPrefs.GetFloat(musicVolTypeKey);
        Slider_SetMusicVolume();
        //if (PlayerPrefs.HasKey(musicVolTypeKey))
        //{
        //    musicSlider.value = PlayerPrefs.GetFloat(musicVolTypeKey);
        //    Slider_SetMusicVolume();
        //}
        //else
        //{

        //    musicSlider.value = 1f;
        //}
    }

    public void Slider_SetSFXVolume()
    {
        PlayerPrefs.SetFloat(sfxVolTypeKey, sfxSlider.value);
        audioMixer.SetFloat("sfxVol", sfxSlider.value);
    }

    public void Slider_SetMusicVolume()
    {
        PlayerPrefs.SetFloat(musicVolTypeKey, musicSlider.value);
        audioMixer.SetFloat("musicVol", musicSlider.value);
    }
}
