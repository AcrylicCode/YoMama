using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreEntry : MonoBehaviour
{
    public Text rankText;
    public Text nameText;
    public Text scoreText;

    public void SetScore (string rank, string name, string score)
    {
        rankText.text = rank;
        nameText.text = name;
        scoreText.text = score;
    }
}
