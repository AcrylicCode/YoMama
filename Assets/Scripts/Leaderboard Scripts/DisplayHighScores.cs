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
    public GameObject entryprefab;
    public float entryHeight = 55;
    public ScrollRect scrollView;
    public RectTransform contentPanel;

	private HighScores highscoresManager = null;

    private List<GameObject> entries = new List<GameObject>();

	// Use this for initialization
	void Start()
	{
		highscoresManager = GetComponent<HighScores>();
		StartCoroutine("RefreshHighscores");
	}

	public void OnHighscoresDownloaded(Highscore[] highscoreList)
	{
        if (contentPanel != null && entryprefab != null)
        {
            //delete old entries
            for(int i = 0; i < entries.Count; i++)
            {
                DestroyImmediate(entries[i]);
            }
            entries.Clear();

            float overallPanelHeight = 0;
            for (int i = 0; i < highscoreList.Length; i++)
            {
                if (i < highscoreEntryNumber)
                {
                    //In the name field, get rid of the time stamp.
                    string username = highscoreList[i].username.Split(new char[] { '-' }, System.StringSplitOptions.RemoveEmptyEntries)[0];
                    username = username.Replace("+", " ");

                    GameObject newEntry = GameObject.Instantiate(entryprefab, contentPanel);
                    newEntry.GetComponent<HighScoreEntry>().SetScore((i+1) + ".", username, highscoreList[i].score.ToString());
                    entries.Add(newEntry);

                    overallPanelHeight += entryHeight;

                    if (i % 2 == 0)
                    {
                        Color panelColor = newEntry.GetComponent<Image>().color;
                        panelColor.a = 0;
                        newEntry.GetComponent<Image>().color = panelColor;
                    }
                }
                else
                {
                    //highscoreText[i].text += "  --:--";
                }
            }
            //set size of content panel to fit entries
            contentPanel.sizeDelta = new Vector2(contentPanel.sizeDelta.x, overallPanelHeight);
        }
	}
	
	IEnumerator RefreshHighscores()
	{
		while (true)
		{
			highscoresManager.downloadHighscores();
			yield return new WaitForSeconds(30);
		}

        scrollView.normalizedPosition = Vector2.zero;
	}
}
