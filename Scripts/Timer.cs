using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public float timerval;
    public Text display;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        timerval = timerval - Time.deltaTime;
        print("test" + timerval);
        display.text = "" + timerval;
	}
}
