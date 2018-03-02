using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PlayFab;
using PlayFab.ClientModels;


public class StatisticLeaderboard : MonoBehaviour
{
    [Tooltip("Number of letters to remove from the end of the Display Name because of the unique number ID attached to the end")]
    public int nameSuffixLength = 4;
    public int highscoreEntryNumber = 100;
    public string statisticName = "";
    public HighScoreEntry entryprefab;
    [Tooltip("Separate entry to show players position and score in relation to other players")]
    public HighScoreEntry playerScoreEntry;
    public RectTransform contentPanel;

    
    private PlayerProfileModel playerProfile;
    private List<HighScoreEntry> entries = new List<HighScoreEntry>();

    // Use this for initialization
    public void Awake()
    {
        InstantiateScoreTexts();

        PlayFabLogin.LoginSuccess += EventHandler_LoginSuccess;
    }

    private void EventHandler_LoginSuccess(PlayerProfileModel received_profile)
    {
        PlayFabLogin.LoginSuccess -= EventHandler_LoginSuccess;
        playerProfile = received_profile;
    }

    private void InstantiateScoreTexts()
    {
        if (entryprefab != null && contentPanel != null)
        {
            float newHeight = 0;
            for (int i = 0; i < highscoreEntryNumber; i++)
            {
                HighScoreEntry newEntry = (HighScoreEntry)Instantiate((Object)entryprefab);
                newEntry.transform.parent = contentPanel;
                newEntry.SetScore((i + 1) + ".", "--|--", "--");
                newHeight += newEntry.GetComponent<RectTransform>().sizeDelta.y;
                newEntry.transform.localScale = Vector3.one;
                entries.Add(newEntry);
            }

            //set height to match number of entries
            contentPanel.sizeDelta = new Vector2(contentPanel.sizeDelta.x, newHeight);
        }
    }

    private void UpdateLeaderboardTable()
    {
        //set initial data in Player Score entry. Set here first in case it is not found in the leaderboard
        if(playerScoreEntry != null)
            playerScoreEntry.SetScore(
                            "--",
                            FixUserName(playerProfile),
                            "--");

        PlayFabClientAPI.GetLeaderboard
            (
            new GetLeaderboardRequest { StartPosition = 0, MaxResultsCount = highscoreEntryNumber, StatisticName = statisticName },
            result =>
            {
                //Debug.Log("Updated leaderboard for: " + statisticName);
                for (int i = 0; i < entries.Count; i++)
                {
                    if (i < result.Leaderboard.Count)
                    {
                        PlayerLeaderboardEntry data = result.Leaderboard[i];

                        //set entry
                        entries[i].SetScore(
                            (data.Position + 1) + ".",
                            FixUserName(data.Profile),
                            data.StatValue.ToString());

                        //assign player values based on leaderboard if found
                        if (result.Leaderboard[i].PlayFabId == playerProfile.PlayerId)
                        {
                            playerScoreEntry.rankText.text = i + 1 + "";
                            playerScoreEntry.SetScore(
                                (data.Position + 1) + ".",
                                FixUserName(playerProfile),
                                data.StatValue.ToString());
                        }
                    }
                    //set as empty entry
                    else
                    {
                        entries[i].SetScore(
                            (i + 1) + ".",
                            "--|--",
                            "--");
                    }
                }
            },
            error =>
            {
                Debug.Log("Error getting High Scores");
                Debug.Log(error.GenerateErrorReport());
            }

            );
    }

    private string FixUserName(PlayerProfileModel profileToFix)
    {
        string username = profileToFix.PlayerId;
        if (profileToFix.DisplayName != null)
        {
            username = profileToFix.DisplayName;
            username = username.Substring(0, username.Length - nameSuffixLength);
        }

        return username;
    }

    public void SetPlayerHighScore(int value)
    {
        StartCoroutine("DoSetPlayerHighScore", value);
    }

    private IEnumerator DoSetPlayerHighScore(int value)
    {
        PlayFabClientAPI.UpdatePlayerStatistics(new UpdatePlayerStatisticsRequest
        {
            Statistics = new List<StatisticUpdate>
                {
                    new StatisticUpdate { StatisticName = statisticName, Value = value }
                }
        },
            success =>
            {
                Debug.Log("Set new score for:" + statisticName);
            },
            error =>
            {
                Debug.Log("Got error setting score:");
                Debug.Log(error.GenerateErrorReport());
            }
        );

        yield return new WaitForSeconds(2);

        UpdateLeaderboardTable();

        yield return null;
    }

    public void SetStatistic(string setStatName)
    {
        statisticName = setStatName;
    }
}