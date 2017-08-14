using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	private Animator animator;
	public ScoreText scoreText;
	public float speed = 0.01f;
	public static bool deathFlg = false;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		deathFlg = false;
	}

	public static bool getDeathFlg(){
		return deathFlg;
	}

	// Update is called once per frame
	void Update () {
		Locomotion ();
		if (this.gameObject.transform.position.y < -1) {
			deathFlg = true;
			SceneManager.LoadScene("Result");
		}

	}


	void OnCollisionEnter(Collision coll){
		if (coll.gameObject.tag == "Cola") {
			Destroy (coll.gameObject);
			scoreText.GetComponent<ScoreText>().plusScore();
		}

	}

	void Locomotion(){
		
		if (Input.GetKey("up")) {
			transform.rotation = Quaternion.Euler(0, -90, 0);
			transform.position += transform.forward * speed;
			animator.SetBool("is_running", true);
		} else {
			animator.SetBool("is_running", false);
		}

		if (Input.GetKey("right")) {
			transform.rotation = Quaternion.Euler(0, 0, 0);
			transform.position += transform.forward * speed;
			animator.SetBool("is_running", true);
		}

		if (Input.GetKey ("left")) {
			transform.rotation = Quaternion.Euler(0, 180, 0);
			transform.position += transform.forward * speed;
			animator.SetBool("is_running", true);
		}

		if (Input.GetKey ("down")) {
			transform.rotation = Quaternion.Euler(0, 90, 0);
			transform.position += transform.forward * speed;
			animator.SetBool("is_running", true);
		}

	}


}
