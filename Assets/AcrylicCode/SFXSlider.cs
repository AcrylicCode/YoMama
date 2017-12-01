using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXSlider : MonoBehaviour
{
    public AudioSource sfxSource;
	
	public void SliderUpdated ()
    {
        if (sfxSource.isPlaying == false)
            //StartCoroutine("PlaySound");
            sfxSource.Play();
	}

    IEnumerator PlaySound()
    {

        yield return null;
    }
}
