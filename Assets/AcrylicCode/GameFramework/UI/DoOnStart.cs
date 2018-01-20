using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DoOnStart : MonoBehaviour
{
    public UnityEvent doOnStart = new UnityEvent();
	// Use this for initialization
	void Start ()
    {
        doOnStart.Invoke();
	}
}
