using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ResultScoreText : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.GetComponent<Text>().text = "SCORE：" + (ScoreText.getScore()).ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
