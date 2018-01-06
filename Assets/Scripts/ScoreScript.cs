using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{
    //PUBLIC
    public Color goodColor = Color.green;
    public Color badColor = Color.red;
    public float comboIncrememnt = 0.1f;
    public Text scoreText;
    public GameObject mama;
    public Animator mamaAnim;
    public AnimationClip mamaHappyClip;
    public AnimationClip mamaSadClip;
    public Animation addScoreAnim;
    public Transform mamaMouth;
    public Text addScoreText;

    public UnityEvent doOnEnd = new UnityEvent();
    
    //PRIVATE
    private int scoreNum = 0;
    private int correctResponseCount = 0;
    private UnityAction restartListener;
    private UnityAction gameOverListener;

    


    void Awake()
    {
        restartListener = new UnityAction(restartGame);
        gameOverListener = new UnityAction(gameEnd);

        TriggerAddScore.Event_AddScore += EventListener_Addscore;
    }

    void OnEnable()
    {
        EventManager.StartListening("restart", restartListener);
        EventManager.StartListening("gameOver", gameOverListener);
    }

    void OnDisable()
    {
        EventManager.StopListening("restart", restartListener);
        EventManager.StopListening("gameOver", gameOverListener);
    }

    void EventListener_Addscore(TriggerAddScore.ScoreType scoreType)
    {
        int addScore = (int)scoreType;
        string comboString = "";
        //positive
        if (addScore >= 0)
        {
            //increment combo count
            correctResponseCount++;
            float totalCombo = (1 + (correctResponseCount * comboIncrememnt));
            if (totalCombo > 10) totalCombo = 10;
            comboString = " * " + totalCombo;

            //change add-score text
            addScoreText.text = "+" + addScore + comboString;
            addScoreText.color = goodColor;

            //add to final score
            scoreNum += (int)(addScore * totalCombo);

            //play mama reaction
            mamaAnim.Play(mamaHappyClip.name);
        }
        //negative
        else
        {
            //increment combo count
            correctResponseCount = 0;

            //change add-score text
            addScoreText.text = "" + addScore;
            addScoreText.color = badColor;

            //add to final score
            scoreNum += addScore;

            //play mama reaction
            mamaAnim.Play(mamaSadClip.name);
        }

        //play add-score animation
        addScoreText.transform.position = mamaMouth.position;
        addScoreAnim.Stop();
        addScoreAnim.Play();

        //display score text
        scoreText.text = "lbs: " + scoreNum;

        //update mamas size
        mama.transform.localScale = new Vector3(scoreNum / 500f + 4f, scoreNum / 550f + 3f, 0);
    }

    void restartGame()
    {
        Debug.Log("Restarted score");
        scoreNum = 0;
        scoreText.text = "lbs: " + scoreNum;
        mamaAnim.Play(mamaHappyClip.name);
    }

    void gameEnd()
    {
        Debug.Log("Ending");
        //finalScore is the players score
        PlayerPrefs.SetInt("finalScore", scoreNum);
        //Load the AddNewHighScore scene

        doOnEnd.Invoke();
    }

}
