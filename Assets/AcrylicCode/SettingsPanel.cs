﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsPanel : MonoBehaviour
{
    //PUBLIC
    [Header("Sound Settings")]
    public float maxVolume = 0;
    public float midVolume = -20;
    public float minVolume = -80;
    public AudioMixer audioMixer;
    public Slider sfxSlider;
    private string sfxVolTypeKey = "SFX Volume";
    public Slider musicSlider;
    private string musicVolTypeKey = "Music Volume";

    

    void Start()
    {
        //SFX Volume start
        if (!PlayerPrefs.HasKey(sfxVolTypeKey))
            PlayerPrefs.SetFloat(sfxVolTypeKey, 0.5f);

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
        if(!PlayerPrefs.HasKey(musicVolTypeKey))
            PlayerPrefs.SetFloat(musicVolTypeKey, 0.5f);

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
        audioMixer.SetFloat("sfxVol", ConvertVolumeInput(sfxSlider.value));
    }

    public void Slider_SetMusicVolume()
    {
        PlayerPrefs.SetFloat(musicVolTypeKey, musicSlider.value);
        audioMixer.SetFloat("musicVol", ConvertVolumeInput(musicSlider.value));
    }

    float ConvertVolumeInput(float sliderInput)
    {
        float convertedVolume = 0;

        if( sliderInput >= 0.5f)
        {
            convertedVolume = Mathf.Lerp(-20, 0, (sliderInput - 0.5f) * 2);
        }
        else
        {
            convertedVolume = Mathf.Lerp(-80, -20, sliderInput * 2);
        }

        return convertedVolume;
    }
}
