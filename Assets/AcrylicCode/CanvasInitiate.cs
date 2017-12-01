using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RectTransform))]
public class CanvasInitiate : MonoBehaviour
{
    [System.Serializable]
    public class AudioSettings
    {
        public AudioSource audio;
        public float originalVolume = 0;
    }

    //PUBLIC

    //Transform
    [Header("Transform Settings")]
    [Tooltip("Transform to line up with when first loaded")]
    public RectTransform parentPanel;

    //Canvas Group
    [Header("Canvas Group Settings")]
    public bool changeCanvasGroupOnStartup = false;
    [Tooltip("Alpha when first loaded")]
    [Range(0,1)]public float startAlpha = 0;
    [Tooltip("How long it takes to fade in and out")]
    public float fadeTime = 0.25f;
    [Tooltip("Toggle whether is interactable when visible")]
    public bool interactable = true;
    [Tooltip("Toggle whether it blocks raycast when visible")]
    public bool blocksRaycasts = true;

    //Image
    [Header("Image Settings on Start")]
    public bool changeImageOnStartup = false;
    public Color imageColor = Color.white;

    //PRIVATE
    private AudioSettings[] audioSettings = new AudioSettings[0];

    private void Awake()
    {
        //Store original audio settings
        StoreAudioSettings();

        //set initial audio volumes
        for(int i = 0; i < audioSettings.Length; i++)
        {
            audioSettings[i].audio.volume = Mathf.Lerp(0, audioSettings[i].originalVolume, startAlpha);
        }

        //Transform initialization
        if (parentPanel != null)
        {
            //move back into place to be lined back up with parent
            if (this.transform.parent != parentPanel) this.transform.SetParent(parentPanel);
            this.GetComponent<RectTransform>().localPosition = Vector3.zero;
            this.GetComponent<RectTransform>().sizeDelta = Vector4.zero;
        }

        //Canvas group initialization
        CanvasGroup canvasGroup = this.GetComponent<CanvasGroup>();
        if (changeCanvasGroupOnStartup && canvasGroup != null)
        {
            canvasGroup.alpha = startAlpha;

            if (startAlpha > 0)
            {
                canvasGroup.interactable = interactable;
                canvasGroup.blocksRaycasts = blocksRaycasts;
            }
            else
            {
                canvasGroup.interactable = false;
                canvasGroup.blocksRaycasts = false;
            }
        }

        //Image initialization
        Image image = this.GetComponent<Image>();
        if (changeImageOnStartup && image != null)
        {

        }
    }

    void StoreAudioSettings()
    {
        AudioSource[] audioChildren = this.GetComponentsInChildren<AudioSource>();
        audioSettings = new AudioSettings[audioChildren.Length];
        for(int i = 0; i < audioChildren.Length; i++)
        {
            AudioSettings newAudio = new AudioSettings();
            newAudio.audio = audioChildren[i];
            newAudio.originalVolume = audioChildren[i].volume;

            audioSettings[i] = newAudio;
        }
    }

    public void FadeCanvasGroup(float fadeToAlpha)
    {
        StopAllCoroutines();
        StartCoroutine("DoFadeCanvasGroup", fadeToAlpha);
    }

    IEnumerator DoFadeCanvasGroup(float fadeToAlpha)
    {
        CanvasGroup canvasGroup = this.GetComponent<CanvasGroup>();
        if (canvasGroup != null)
        {
            if (fadeToAlpha > 0)
                canvasGroup.interactable = interactable;
            else
                canvasGroup.interactable = false;

            float time = 0;
            float canvasAlpha = canvasGroup.alpha;
            while (time < fadeTime)
            {
                time += Time.unscaledDeltaTime;

                float newAlpha = Mathf.Lerp(canvasAlpha, fadeToAlpha, time / fadeTime);
                newAlpha = (float)System.Math.Round(newAlpha, 3);

                //fade canvas group
                canvasGroup.alpha = newAlpha;

                //set audio levels
                for (int i = 0; i < audioSettings.Length; i++)
                {
                    audioSettings[i].audio.volume = Mathf.Lerp(0, audioSettings[i].originalVolume, newAlpha);
                }

                yield return null;
            }
            canvasGroup.alpha = fadeToAlpha;

            if (fadeToAlpha > 0)
                canvasGroup.blocksRaycasts = blocksRaycasts;
            else
                canvasGroup.blocksRaycasts = false;

            yield return null;
        }
        

        yield return null;
    }
}
