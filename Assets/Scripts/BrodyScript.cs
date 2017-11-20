using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BrodyScript : MonoBehaviour {

    private UnityAction greatScoreListener;
    private UnityAction goodScoreListener;
    private UnityAction badScoreListener;
    private UnityAction veryBadScoreListener;

    public Animator anim;
    public AnimationClip throwClip;

    void Awake()
    {
        greatScoreListener = new UnityAction(BrodyThrow);
        goodScoreListener = new UnityAction(BrodyThrow);
        badScoreListener = new UnityAction(BrodyThrow);
        veryBadScoreListener = new UnityAction(BrodyThrow);
    }
    void OnEnable()
    {
        EventManager.StartListening("greatTrigger", greatScoreListener);
        EventManager.StartListening("goodTrigger", goodScoreListener);
        EventManager.StartListening("badTrigger", badScoreListener);
        EventManager.StartListening("veryBadTrigger", veryBadScoreListener);
    }
    void OnDisable()
    {
        EventManager.StopListening("greatTrigger", greatScoreListener);
        EventManager.StopListening("goodTrigger", goodScoreListener);
        EventManager.StopListening("badTrigger", badScoreListener);
        EventManager.StopListening("veryBadTrigger", veryBadScoreListener);
    }

    void BrodyThrow()
    {
        Debug.Log("played");
        anim.Play(throwClip.name);
    }
}
