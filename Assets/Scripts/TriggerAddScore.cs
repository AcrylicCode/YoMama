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

    public void AddScore()
    {
        Do_AddScore(scoreType);
    }

}
