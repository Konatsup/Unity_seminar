using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour {

	public static int score = 0;

	// Use this for initialization
	void Start () {
		score = 0;
	}

	public static int getScore(){
		return score;
	}

	public void plusScore(){
		score++;
	}
	// Update is called once per frame
	void Update () {
		this.GetComponent<Text>().text = "SCORE：" + score.ToString();
	}
}
