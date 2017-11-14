using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameLoader : MonoBehaviour
{
    //PUBLIC
    public string sceneName = "";
    public CanvasInitiate loaderCanvas;

    private AsyncOperation loadAsync = null;

    public void LoadLevel()
    {
        StartCoroutine("DoLoadLevel");
    }

    IEnumerator DoLoadLevel()
    {
        if (sceneName != "" && loaderCanvas != null)
        {
            loadAsync = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);

            while (!loadAsync.isDone)
                yield return null;

            SceneManager.SetActiveScene(SceneManager.GetSceneAt(1));
            loaderCanvas.FadeCanvasGroup(0);
        }

        yield return null;
    }
}
