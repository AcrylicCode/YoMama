using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ButtonSounds_Component : MonoBehaviour
{
    public AudioClip[] buttonSounds = new AudioClip[0];
    private AudioSource sfxPlayer;

    private void Awake()
    {
        Button thisButton = this.GetComponent<Button>();
        if(thisButton != null)
        {
            thisButton.onClick.AddListener(OnClick);
        }

        GameObject sfxObj = GameObject.Find("SFXPlayer");
        if (sfxObj != null)
            sfxPlayer = sfxObj.GetComponent<AudioSource>();
    }

    void OnClick()
    {
        //Debug.Log("Clicked");
        if (buttonSounds.Length == 0)
            return;

        AudioClip chosenClip = buttonSounds[Random.Range(0, buttonSounds.Length-1)];
        
        if(sfxPlayer != null)
        {
            sfxPlayer.clip = chosenClip;
            sfxPlayer.PlayOneShot(chosenClip);
        }
    }

}
