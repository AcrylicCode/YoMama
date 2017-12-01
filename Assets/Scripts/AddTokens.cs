
using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using UnityEngine.Advertisements;
//using GoogleMobileAds.Api;

public class AddTokens : MonoBehaviour
{
	public GameObject AgreeWatchAdsPanel;
    public UnityEvent doWhileLoading = new UnityEvent();
    public UnityEvent doWhenLoadingFinished = new UnityEvent();
    public UnityEvent doWhenFinished = new UnityEvent();

	public void ShowRewardedVideo()
	{
        StartCoroutine("DoShowRewardedVideo");

//		Advertisement.Initialize ("1552075");
	
//		if(Advertisement.IsReady("rewardedVideo"))
//		{
////			var option = new ShowOptions{resultCallback = HandleAction};
////			Advertisement.Show ("rewardedVideo", option);

//			ShowOptions options = new ShowOptions();
//			options.resultCallback = HandleShowResult;

//			Advertisement.Show("rewardedVideo", options);
//		}
	}

    IEnumerator DoShowRewardedVideo()
    {
        Advertisement.Initialize("1552075");

        doWhileLoading.Invoke();

        while (!Advertisement.IsReady("rewardedVideo"))
            yield return null;
            //			var option = new ShowOptions{resultCallback = HandleAction};
            //			Advertisement.Show ("rewardedVideo", option);

        ShowOptions options = new ShowOptions();
        options.resultCallback = DoShowResult;

        doWhenLoadingFinished.Invoke();

        Advertisement.Show("rewardedVideo", options);

        yield return null;
    }

    public void DoShowResult(ShowResult obj)
    {
        switch (obj)
        {
            case ShowResult.Finished:
                TokenManager.tokenManager.AddTokens(10);
                //int nTokenNumber = TokenManager.tokenManager.tokens;
                //nTokenNumber += 10;

                //if (nTokenNumber >= 30)
                //{
                //    TokenManager.tokenManager.tokens = 30;
                //}
                //else
                //{
                //    TokenManager.tokenManager.tokens = nTokenNumber;
                //}
                //Debug.Log(TokenManager.tokenManager.tokens);

                break;
            case ShowResult.Failed:
                Debug.Log("Player is failed.");
                break;
            case ShowResult.Skipped:
                Debug.Log("Player is skipped");
                break;
        }
        doWhenFinished.Invoke();
    }
}