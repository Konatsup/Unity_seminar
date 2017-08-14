using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultText : MonoBehaviour {
	


	// Use this for initialization
	void Start () {
		//this.GetComponent<Text>().text = "aaaa";

	}


	// Update is called once per frame
	void Update () {

	}

	public void setResult(string s){
		this.GetComponent<Text>().text = s;
	}
}
