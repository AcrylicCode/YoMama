using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class VolumeSliderManager : MonoBehaviour {

	public string volTypeKey;
//	public SoundScript controllSound;
	public AudioSource source;
    public Slider slider;
	AudioListener controlSound;


	void Awake () {
//		source = GetComponent<AudioSource> ();
		source = GameObject.FindObjectOfType<AudioSource> ();

		controlSound = new AudioListener ();
		switch(gameObject.name.Substring(0,3)){
		case "SFX":
			volTypeKey = "SFX Volume";
			source.volume = PlayerPrefsManager.GetSfxVolume();
			if(PlayerPrefs.HasKey(volTypeKey)){

                    slider.value = PlayerPrefsManager.GetSfxVolume();

			} else {

                    slider.value = .5f;
			}
			break;
		case "Mus":
			volTypeKey = "Music Volume";
			source.volume = PlayerPrefsManager.GetSfxVolume();
			if(PlayerPrefs.HasKey(volTypeKey)){

                    slider.value = PlayerPrefsManager.GetMusicVolume();

			} else {

                    slider.value = .5f;

			}
			break;
		}
	}

	public void saveValue(){
		Debug.Log (source);
		if (volTypeKey == "SFX Volume") {

			source.volume = slider.value;


//			AudioListener.volume = gameObject.GetComponent <Slider> ().value;
//			PlayerPrefsManager.SetSfxVolume(gameObject.GetComponent <Slider> ().value);

		} else {
			source.volume = slider.value;
			//			AudioListener.volume = gameObject.GetComponent <Slider> ().value;

//			PlayerPrefsManager.SetMusicVolume (gameObject.GetComponent <Slider> ().value);

		}

	}
}