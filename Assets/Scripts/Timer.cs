using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

	public float timeLimit = 0;
	public TimerText timerText;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timeLimit -=Time.deltaTime;
		timerText.GetComponent<TimerText> ().timer = timeLimit;

		if (timeLimit < 0) {

			SceneManager.LoadScene("Result");
		}


	}
}
