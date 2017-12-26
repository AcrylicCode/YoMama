
using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Advertisements;
//using GoogleMobileAds.Api;

public class AddTokens : MonoBehaviour
{
    [System.Serializable]
    public class Purchase_Tokens
    {
        public string productID;
        public int tokenAmount = 10;
    }

    [Header("Ads")]
    public string gameID = "";
    //public GameObject AgreeWatchAdsPanel;
    [Header("IAP")]
    public Purchase_Tokens[] tokenPurchases = new Purchase_Tokens[0];
    //public string buyTokensProductID = "";
    //public int buyTokensRewardAmount = 30;
    [Header("Events")]
    public UnityEvent doWhileLoading = new UnityEvent();
    public UnityEvent doWhenLoadingFinished = new UnityEvent();
    public UnityEvent doWhenFinished = new UnityEvent();

	public void ShowRewardedVideo()
	{
        StartCoroutine("DoShowRewardedVideo");
	}

    IEnumerator DoShowRewardedVideo()
    {
        //Advertisement.Initialize("1552075");
        Advertisement.Initialize(gameID);

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

    private void Awake()
    {
        for (int i = 0; i < tokenPurchases.Length; i ++)
        {
            Purchaser.productListConsumable.Add(tokenPurchases[i].productID);
        }
    }

    public void IAP_BuyTokens(int purchaseEntryNumber)
    {
        Purchaser.ProcessCompleteEvent += EventHandler_Complete_BuyTokens;
        Purchaser.instance.BuyProductID(tokenPurchases[purchaseEntryNumber].productID);
    }

    void EventHandler_Complete_BuyTokens(string productID)
    {
        Purchaser.ProcessCompleteEvent -= EventHandler_Complete_BuyTokens;

        doWhenLoadingFinished.Invoke();
        doWhenFinished.Invoke();

        for (int i = 0; i < tokenPurchases.Length; i++)
        {
            if(tokenPurchases[i].productID == productID)
                TokenManager.tokenManager.AddTokens(tokenPurchases[i].tokenAmount);
        }
    }
}