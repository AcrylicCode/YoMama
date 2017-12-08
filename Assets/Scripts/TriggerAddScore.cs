using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAddScore : MonoBehaviour {

    public enum ScoreType
    {
        great = 15,
        good = 10,
        bad = -5,
        veryBad = -10
    }

    public delegate void AddScoreEvent(ScoreType scoreType);
    public static AddScoreEvent Event_AddScore;
    public void Do_AddScore(ScoreType scoreType) { if (Event_AddScore != null) Event_AddScore(scoreType); }

    public ScoreType scoreType = ScoreType.good;
    public GameObject ScoreAdd;
    public GameObject Parent;
    public GameObject Score;
    private Vector3 spacer;
    private Vector3 scorePos;

    void Start()
    {
        Parent = GameObject.FindGameObjectWithTag("Canvas");
        Score = GameObject.FindGameObjectWithTag("Score");
        spacer = new Vector3(0, 0, 0);
        scorePos = Score.transform.position;
    }

    public void AddScore()
    {
        //Instantiate(ScoreAdd, scorePos + spacer, Quaternion.identity, Parent.transform);
        Do_AddScore(scoreType);
    }

}
