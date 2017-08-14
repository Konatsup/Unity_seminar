using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultManager : MonoBehaviour {
	int resultScore;
	public int happyScore = 1;
	public GameObject player;
	public ResultText resultText;
	private Animator animator;
	string s;





	// Use this for initialization
	void Start () {
		resultScore = ScoreText.getScore ();
		animator = player.GetComponent<Animator>();

		if (Player.getDeathFlg ()) {
			s = "GAME OVER";
			resultText.setResult(s);
			animator.SetBool ("sad", true);
		} else {

			if (resultScore > happyScore) {
				s = "GAME COMPLETE";
				resultText.setResult(s);
				animator.SetBool ("happy", true);
	
			} else {
				s = "GAME CLEAR";
				resultText.setResult(s);
				animator.SetBool ("soso", true);

			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
