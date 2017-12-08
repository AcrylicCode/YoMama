using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SoundScript : MonoBehaviour
{

    public AudioClip[] goodEatSounds = new AudioClip[0];
    public AudioClip[] badEatSounds = new AudioClip[0];
    public AudioClip[] throwSounds = new AudioClip[0];

	//Declares listeners
	private UnityAction foodThrownListener;

	private UnityAction goodFoodEatenListener;
	private UnityAction vGoodFoodEatenListener;
	private UnityAction badFoodEatenListener;
	private UnityAction vBadFoodEatenListener;

	private AudioSource source;

	void Awake()
	{

		//instantiates listeners
		foodThrownListener = new UnityAction(foodThrown);

		goodFoodEatenListener = new UnityAction (goodFoodEaten);
		vGoodFoodEatenListener = new UnityAction (vGoodFoodEaten);
		badFoodEatenListener = new UnityAction (badFoodEaten);
		vBadFoodEatenListener = new UnityAction (vBadFoodEaten);

		//instantiates AudioSource
		source = GetComponent<AudioSource>();
	}

	// Use this for initialization
	void Start () {
		//triggers the sound of food being thrown, no matter what type of food
		EventManager.StartListening("greatTrigger", foodThrownListener);
		EventManager.StartListening("goodTrigger", foodThrownListener);
		EventManager.StartListening("badTrigger", foodThrownListener);
		EventManager.StartListening("veryBadTrigger", foodThrownListener);

		EventManager.StartListening ("goodFoodEatenTrigger", goodFoodEaten);
		EventManager.StartListening ("vGoodFoodEatenTrigger", vGoodFoodEaten);
		EventManager.StartListening ("badFoodEatenTrigger", badFoodEaten);
		EventManager.StartListening ("vBadFoodEatenTrigger", vBadFoodEaten);
	}

	void foodThrown(){
        //int soundToPlay = Random.Range (0, 4);
        //switch (soundToPlay) {
        //	case 0:
        //		source.PlayOneShot (throwSound, sfxVol);
        //		break;
        //	case 1:
        //		source.PlayOneShot (throwSound2, sfxVol);
        //		break;
        //	case 2:
        //		source.PlayOneShot (throwSound3, sfxVol);
        //		break;
        //	case 3:
        //		source.PlayOneShot (throwSound4, sfxVol);
        //		break;
        //	default:
        //		source.PlayOneShot (throwSound, sfxVol);
        //		break;
        //}
        PlayRandomSound(throwSounds);
    }

	void goodFoodEaten(){
        //source.PlayOneShot (goodEat, sfxVol);
        PlayRandomSound(goodEatSounds);
    }
	void vGoodFoodEaten(){
		//source.PlayOneShot (vGoodEat, sfxVol);
        PlayRandomSound(goodEatSounds);
    }
	void badFoodEaten(){
        //source.PlayOneShot (badEat, sfxVol);
        PlayRandomSound(badEatSounds);
    }
	void vBadFoodEaten(){
        //source.PlayOneShot (vBadEat, sfxVol);
        PlayRandomSound(badEatSounds);
    }

    void PlayRandomSound(AudioClip[] soundArray)
    {
        int num = Random.Range(0, soundArray.Length);
        source.PlayOneShot(soundArray[num]);
    }

	public void setVolume(string type, float volume){
		if(type == "sfx")
		{
			//Debug.Log ("11111111111111111");
			//source.volume = volume;
		}else{
			//Debug.Log ("22222222222222222");
			//source.volume = volume;
		}
	}
}