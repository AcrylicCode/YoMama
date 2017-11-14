using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OpeningLoader : MonoBehaviour
{
    //PUBLIC
    public string sceneName = "";
    public Image loadingBarImage;
    public float waitTime = 0.5f;
    public float loadTransitionSpeed = 0.5f;
    public CanvasInitiate loaderCanvas;

    private string thisSceneName;
    private AsyncOperation loadAsync = null;
    private float time = 0;

    public void Awake()
    {
        loadingBarImage.fillAmount = 0;
        thisSceneName = SceneManager.GetActiveScene().name;

        StartCoroutine("LoadLevel");
    }

    IEnumerator LoadLevel()
    {
        if (sceneName != "" && loaderCanvas != null)
        {
            loadAsync = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);

            while (loadingBarImage.fillAmount < 1)
                yield return null;

            SceneManager.SetActiveScene(SceneManager.GetSceneAt(1));
            loaderCanvas.FadeCanvasGroup(0);
            yield return new WaitForSeconds(loaderCanvas.fadeTime);
            SceneManager.UnloadSceneAsync(thisSceneName);
        }

        yield return null;
    }

    void Update()
    {
        if (loadAsync != null && loadingBarImage.fillAmount < 1)
        {
            float progress = Mathf.Clamp01(loadAsync.progress / 0.9f);
            time += Time.deltaTime * loadTransitionSpeed;
            loadingBarImage.fillAmount = Mathf.Clamp01(Mathf.Lerp(loadingBarImage.fillAmount, progress, time / 1f));
        }
    }
}
