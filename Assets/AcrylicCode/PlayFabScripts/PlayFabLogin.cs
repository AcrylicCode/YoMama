using PlayFab;
using PlayFab.ClientModels;
using UnityEngine;
using System.Collections.Generic;

public class PlayFabLogin : MonoBehaviour
{
    public void Start()
    {
        PlayFabSettings.TitleId = "A9C5"; // Please change this value to your own titleId from PlayFab Game Manager

        var request = new LoginWithCustomIDRequest { CustomId = "GettingStartedGuide", CreateAccount = true };
        PlayFabClientAPI.LoginWithCustomID(request, OnLoginSuccess, OnLoginFailure);
    }

    private void OnLoginSuccess(LoginResult result)
    {
        Debug.Log("Congratulations, you made your first successful API call!");

        ClientGetTitleData();
        ClientGetPlayerStat();
        ClientSetPlayerStat();
    }

    public void ClientGetTitleData()
    {
        PlayFabClientAPI.GetTitleData(new GetTitleDataRequest(),
            result => {
                if (result.Data == null || !result.Data.ContainsKey("personName")) Debug.Log("No Name");
                else Debug.Log("PersonName: " + result.Data["personName"]);
            },
            error => {
                Debug.Log("Got error getting titleData:");
                Debug.Log(error.GenerateErrorReport());
            }
        );
    }

    public void ClientGetPlayerStat()
    {
        PlayFabClientAPI.GetPlayerStatistics(new GetPlayerStatisticsRequest(),
            result => {
                Debug.Log(result.Statistics[0].StatisticName + ": " + result.Statistics[0].Value);
            },
            error => {
                Debug.Log("Got error getting score:");
                Debug.Log(error.GenerateErrorReport());
            }
        );
    }

    public void ClientSetPlayerStat()
    {
        PlayFabClientAPI.UpdatePlayerStatistics(new UpdatePlayerStatisticsRequest
        {
            Statistics = new List<StatisticUpdate>
            {
                new StatisticUpdate { StatisticName = "score", Value = 232},
            }
        },
        result => { ClientGetPlayerStat(); },
        error => {
            Debug.Log("Got error getting score:");
            Debug.Log(error.GenerateErrorReport());
        }
        );
    }

    private void OnLoginFailure(PlayFabError error)
    {
        Debug.LogWarning("Something went wrong with your first API call.  :(");
        Debug.LogError("Here's some debug information:");
        Debug.LogError(error.GenerateErrorReport());
    }
}