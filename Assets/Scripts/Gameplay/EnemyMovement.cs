using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {


	public float timeToMoveFor;
	public float speed;

	private int timeMoved = 0;

	public bool movingLeft;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate() {

		timeCounter ();
		Movement ();

	}

	//50 time = 1 block at 1 speed .:. tickrate = 50
	void timeCounter() {

		timeMoved += 1;

		if (timeMoved == timeToMoveFor) {

			movingLeft = !movingLeft;
			timeMoved = 0;
			print ("Distance is distance, changed over");

		}

	}

	void Movement() {

		if (movingLeft) {

			transform.Translate (Vector2.left * speed * Time.deltaTime);

		} else {

			transform.Translate (Vector2.right * speed * Time.deltaTime);

		}

	}



}
