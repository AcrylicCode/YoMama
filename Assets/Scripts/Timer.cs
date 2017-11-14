using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Timer : MonoBehaviour {
    public float gameTime = 30f;

    private Text timer;
    private float timeLeft;
    private bool start = false;
    private bool time = false;

    private UnityAction startListener;
    private UnityAction restartListener;

    void Awake()
    {
        startListener = new UnityAction(startTimer);
        restartListener = new UnityAction(restartTimer);
    }

    void OnEnable()
    {
        EventManager.StartListening("start", startListener);
        EventManager.StartListening("restart", restartListener);
    }
    void OnDisable()
    {
        EventManager.StopListening("start", startListener);
        EventManager.StopListening("restart", restartListener);
    }

    // Use this for initialization
    void Start() {
        timer = GetComponent<Text>();
        timer.text = "Time Left: " + gameTime;
	}
	
	// Update is called once per frame
	//void Update () {

 //       if (start)
 //       {
 //           // set Game Time
 //           timeLeft = gameTime;
 //           start = false;
 //       }

 //       if (time)
 //       {
 //           timeLeft -= Time.deltaTime;
 //           timer.text = "Time Left: " + timeLeft.ToString("0.0");
 //       }
 //       if (timeLeft < 0)
 //       {
 //           timer.text = "Time Left: 0.0";
 //           time = false;
 //           EventManager.triggerEvent("gameOver");
 //       }
 //   }

    IEnumerator DoStartTimer()
    {
        while(timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timeLeft = Mathf.Clamp(timeLeft, 0, gameTime); //make sure it doesn't go below zero
            timer.text = "Time Left: " + timeLeft.ToString("0.0");
            yield return null;
        }

        timer.text = "Time Left: 0.0";
        EventManager.triggerEvent("gameOver");

        yield return null;
    }

    void startTimer()
    {
        timeLeft = gameTime;
        start = true;
        time = true;
        StartCoroutine("DoStartTimer");
    }

    void restartTimer()
    {
        StopCoroutine("DoStartTimer");
        timeLeft = gameTime;
        timer.text = "Time Left: " + gameTime;
        start = false;
        time = false;
    }
}
