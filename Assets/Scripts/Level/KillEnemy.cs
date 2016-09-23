using UnityEngine;
using System.Collections;

public class KillEnemy : MonoBehaviour {


	public GameObject enemy;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter2D(Collider2D other)
	{
		print ("Something entered the collider");

		//If an enemy goes onto a death box the enemy gets destroyed
		if (other.tag == "Player") {

			print ("Enemy entered collider and was destroyed");
			Destroy (enemy);

		}


	}



}
