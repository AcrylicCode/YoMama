﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PlayFab;
using PlayFab.ClientModels;

public class StatisticLeaderboard : MonoBehaviour
{
    public string statisticName = "";
    [Tooltip("Number of letters to remove from the end of the Display Name because of the unique number ID attached to the end")]
    public int nameSuffixLength = 4;
    public int highscoreEntryNumber = 100;
    public HighScoreEntry entryprefab;
    public RectTransform contentPanel;

    private List<HighScoreEntry> entries = new List<HighScoreEntry>();

    // Use this for initialization
    private void Awake ()
    {
        InstantiateScoreTexts();
        PlayFabLogin.LoginSuccess += UpdateLeaderboardTable;
    }

    private void InstantiateScoreTexts()
    {
        if(entryprefab != null && contentPanel != null)
        {
            float newHeight = 0;
            for (int i = 0; i < highscoreEntryNumber; i++)
            {
                HighScoreEntry newEntry = (HighScoreEntry)Instantiate((Object)entryprefab);
                newEntry.transform.parent = contentPanel;
                newEntry.SetScore((i+1) + ".", "--|--", "--");
                newHeight += newEntry.GetComponent<RectTransform>().sizeDelta.y;
                newEntry.transform.localScale = Vector3.one;
                entries.Add(newEntry);
            }

            //set height to match number of entries
            contentPanel.sizeDelta = new Vector2(contentPanel.sizeDelta.x, newHeight);
        }
    }

    public void UpdateLeaderboardTable()
    {
        PlayFabClientAPI.GetLeaderboard
            (
            new GetLeaderboardRequest { StartPosition = 0, MaxResultsCount = 100, StatisticName = statisticName },
            result => 
            {
                Debug.Log("Updated leaderboard for: " + statisticName);
                for (int i = 0; i < entries.Count; i++)
                {
                    if(i < result.Leaderboard.Count)
                    {
                        //remove unique number ID suffix
                        string displayName = result.Leaderboard[i].DisplayName;
                        displayName = displayName.Substring(0, displayName.Length - nameSuffixLength);

                        //set entry
                        entries[i].SetScore((i+1) + ".", displayName, result.Leaderboard[i].StatValue.ToString());
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
}
