// Code from Git Hub
// Added Code by Joshua Janik
// 5/23/2017

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayHighScores : MonoBehaviour
{
    public int highscoreEntryNumber = 100;
    public Object entryprefab;
    public RectTransform contentPanel;

    public Text[] highscoreText;

    private HighScores highscoresManager = null;

    private HighScoreEntry[] entries = new HighScoreEntry[0];

	// Use this for initialization
	void Start()
	{
		highscoresManager = GetComponent<HighScores>();
		StartCoroutine("RefreshHighscores");

        entries = contentPanel.GetComponentsInChildren<HighScoreEntry>(true);
    }

	public void OnHighscoresDownloaded(Highscore[] highscoreList)
	{
        for (int i = 0; i < entries.Length; i++)
        {
            if (i < highscoreList.Length)
            {
                //In the name field, get rid of the time stamp.
                string username = highscoreList[i].username.Split(new char[] { '-' }, System.StringSplitOptions.RemoveEmptyEntries)[0];
                username = username.Replace("+", " ");

                entries[i].SetScore("#" + (i + 1), username, highscoreList[i].score.ToString());
            }
            else
            {
                entries[i].SetScore("#" + (i + 1), "--:--", "N/A");
            }

            if (i % 2 == 0)
            {
                Color panelColor = entries[i].GetComponent<Image>().color;
                panelColor.a = 0;
                entries[i].GetComponent<Image>().color = panelColor;
            }
        }

        
        if (contentPanel != null)
        {
            
            for (int i = 0; i < entries.Length; i++)
            {
                if(i < highscoreList.Length)
                {
                    //entries[i].gameObject.SetActive(true);

                    //In the name field, get rid of the time stamp.
                    string username = highscoreList[i].username.Split(new char[] { '-' }, System.StringSplitOptions.RemoveEmptyEntries)[0];
                    username = username.Replace("+", " ");

                    //GameObject newEntry = GameObject.Instantiate(Resources.Load<GameObject>("Highscore Entry")) as GameObject;
                    //newEntry.transform.SetParent(contentPanel);
                    //Debug.Log(newEntry);
                    //newEntry.GetComponent<HighScoreEntry>().SetScore((i + 1) + ".", username, highscoreList[i].score.ToString());
                    //entries.Add(newEntry);

                    entries[i].SetScore("#" + (i + 1), username, highscoreList[i].score.ToString());
                }
                else
                {
                    entries[i].SetScore("#" + (i + 1), "--:--", "N/A");
                }

                if (i % 2 == 0)
                {
                    Color panelColor = entries[i].GetComponent<Image>().color;
                    panelColor.a = 0;
                    entries[i].GetComponent<Image>().color = panelColor;
                }
            }
            //set size of content panel to fit entries
            //Debug.Log("NUMBER OF ENTRIES " + highscoreList.Length);
            //contentPanel.sizeDelta = new Vector2(contentPanel.sizeDelta.x, entries.Length * entryHeight);
            //Debug.Log("Panel size is " + contentPanel.sizeDelta.y);
        }
    }
	
	IEnumerator RefreshHighscores()
	{
        while (true)
		{
			highscoresManager.downloadHighscores();
            
			yield return new WaitForSeconds(30);
		}
	}
}
