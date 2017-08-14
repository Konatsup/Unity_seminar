using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBall : MonoBehaviour {


	public float timeOut;
	public GameObject sphere;
	public GameObject apple;
	public GameObject cola;
	int randomCount  = 0;

	// Use this for initialization
	void Start () {
		StartCoroutine( FuncCoroutine() );
	}

	// Update is called once per frame
	void Update () {
			
			
	}
		

	IEnumerator FuncCoroutine() {
		while(true){
			// Do anything
			randomCount = Random.Range (0, 3);
			switch (randomCount) {
			case 0:
				Instantiate (sphere.gameObject, new Vector3 (Random.Range (-20f, -6f), Random.Range (20f, 40f), Random.Range (-8f, 8f)), Quaternion.identity);
				break;
			case 1:
				Instantiate (apple.gameObject, new Vector3 (Random.Range (-20f, -6f), Random.Range (20f, 40f), Random.Range (-8f, 8f)), Quaternion.identity);
				break;
			case 2:
				Instantiate (cola.gameObject, new Vector3 (Random.Range (-20f, -6f), Random.Range (20f, 40f), Random.Range (-8f, 8f)), Quaternion.Euler(90, 0, 0));
				break;
			}
			yield return new WaitForSeconds(timeOut);
		}
	}
}
