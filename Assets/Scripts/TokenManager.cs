using System.Collections;
using System.Collections.Generic;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TokenManager : MonoBehaviour {

	//static reference so it can be referenced from other classes easily
	public static TokenManager tokenManager;

	// these values can be adjusted to fine-tune how generous or shrewd we are with free tokens
	private static int numTokensRequired = 5;
	public int maxTokens = 30;

    public float defautTimeTillNext = 180f;
    private float timeTillNextToken;
    private int tokens;
	public DateTime mostRecentTime;
    public UnityEvent doIfNotEnough = new UnityEvent();
    public UnityEvent doIfEnough = new UnityEvent();
    public Text[] tokenAmountTexts = new Text[0];
    public Color textNormalColor = Color.white;
    public Color textOverLimitColor = Color.white;

    // Checks if there is already a token manager. If so, destroys its self
    void Awake () {
		//if (tokenManager == null) {
			//DontDestroyOnLoad (gameObject);
			tokenManager = this;
        //Load ();
        //} else if (tokenManager != this) {
        //	Destroy (gameObject);
        //}
        Load();
        UpdateTokens();

        InvokeRepeating("UpdateTokens", timeTillNextToken, defautTimeTillNext);
	}

    public void CheckIfHasEnough()
    {
        if(tokens >= numTokensRequired)
        {
            doIfEnough.Invoke();
            Save();
        }
        else
        {
            doIfNotEnough.Invoke();
        }
    }

    public void TokensCost()
    {
        tokens -= numTokensRequired;
        if (tokens < 0) tokens = 0;

        UpdateTokenTexts();
    }

	// timer to grant free tokens (if tokens below max)
	void UpdateTokens(){
		if (tokens < maxTokens) {
            AddTokens(1);
		}
        UpdateTokenTexts();
        //Debug.Log("update tokens to " + tokens);
    }

    public void AddTokens(int addAmount)
    {
        tokens += addAmount;

        if (tokens < 0) tokens = 0;

        UpdateTokenTexts();
    }

    void UpdateTokenTexts()
    {
        for (int i = 0; i < tokenAmountTexts.Length; i++)
        {
            if (tokenAmountTexts[i] != null)
            {
                tokenAmountTexts[i].text = tokens + "";

                if (tokens <= maxTokens)
                    tokenAmountTexts[i].color = textNormalColor;
                else
                    tokenAmountTexts[i].color = textOverLimitColor;
            }
        }
    }

	// called when application gains or loses focus
	void OnApplicationFocus(bool hasFocus){
		if (!hasFocus) {
			Save ();
		} else if (hasFocus) {
			Load ();
		}
	}


	// function to save data about tokens to local device
	public void Save(){
		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create(Application.persistentDataPath + "/tokenInfo.dat");

		// makes istance of data container with current data
		TokenData data = new TokenData();
		data.tokens = tokens;
		data.timeLeft = timeTillNextToken;
		data.mostRecentTime = DateTime.Now;

		//writes the data to the specified file (Unity's persistent data path)
		bf.Serialize(file, data);
		file.Close();
	}

	//loads data from file (if it exists)
	public void Load(){
        if (File.Exists(Application.persistentDataPath + "/tokenInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/tokenInfo.dat", FileMode.Open);
            TokenData data = (TokenData)bf.Deserialize(file);
            file.Close();

            tokens = data.tokens;
            timeTillNextToken = data.timeLeft;
            mostRecentTime = data.mostRecentTime;

            //calculates tokens given from time away
            float diffInSeconds = (float)(DateTime.Now - mostRecentTime).TotalSeconds;
            if (diffInSeconds > 0)
            {

                float totalSeconds = timeTillNextToken + diffInSeconds;
                if (tokens < maxTokens)
                {
                    int tokensToAdd = (int)(totalSeconds / defautTimeTillNext);

                    //adds accrued tokens; sets tokens to 30 if they would exceed 30 (max)
                    if (tokensToAdd + tokens > maxTokens)
                    {
                        tokens = maxTokens;
                        UpdateTokenTexts();
                    }
                    else
                    {
                        AddTokens(tokensToAdd);
                    }
                    timeTillNextToken = totalSeconds % defautTimeTillNext;
                }
            }

        }
        //if no previous save, AKA new game
        else
            AddTokens(30);
	}

	// getters for private fields that we don't want other classes modifying
	public int getTokensRequired(){
		return numTokensRequired;
	}
	public float getDefaultTime(){
		return defautTimeTillNext;
	}
	public int getMaxTokens(){
		return maxTokens;
	}
	public int getTokens()
	{
		return tokens;
	}
}

// Data container private class. Holds number of tokens, amount of time left on timer, and the time the game was closed/lost focus
[Serializable]
class TokenData{
	public int tokens;
	public float timeLeft;
	public DateTime mostRecentTime;
}