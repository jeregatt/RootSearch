using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour {

	public Text TimerText;
	private float StartTime;




	// Use this for initialization
	void Start () {
		
		//give us the time since our game starts
		StartTime = Time.time;
	
		
	}
	
	// Update is called once per frame
	void Update () {
		float t = Time.time - StartTime;

		string minutes = ((int)t / 60).ToString ();
		string seconds = (t % 60).ToString("f0");

		TimerText.text = minutes + ":" + seconds;
	}






}
