using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddScoreText : MonoBehaviour
{
    public Color goodColor = Color.green;
    public Color badColor = Color.red;

    void Awake()
    {
        TriggerAddScore.Event_AddScore += EventListener_Addscore;
    }

    void EventListener_Addscore(TriggerAddScore.ScoreType scoreType)
    {
        int score = (int)scoreType;
        Text text = this.GetComponent<Text>();
        //positive
        if (score >= 0)
        {
            text.text = "+" + score;
            text.color = goodColor;
        }
        //negative
        else
        {
            text.text = "" + score;
            text.color = badColor;
        }

        Animation anim = this.GetComponent<Animation>();
        anim.Stop();
        anim.Play();
    }
}
