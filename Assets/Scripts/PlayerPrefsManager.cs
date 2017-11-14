using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerPrefsManager : MonoBehaviour {

	const string SFX_VOLUME_KEY = "SFX Volume";
	const string MUSIC_VOLUME_KEY = "Music Volume";

	public static void SetSfxVolume (float volume) {
		PlayerPrefs.SetFloat (SFX_VOLUME_KEY, volume);
	}

	public static float GetSfxVolume () {
		return PlayerPrefs.GetFloat (SFX_VOLUME_KEY);
	}

	public static void SetMusicVolume (float Volume) {
		PlayerPrefs.SetFloat (SFX_VOLUME_KEY, Volume);
        Debug.Log("set music");
	}

	public static float GetMusicVolume () {
        //Debug.Log("got music");
        return PlayerPrefs.GetFloat (MUSIC_VOLUME_KEY);
    }
}