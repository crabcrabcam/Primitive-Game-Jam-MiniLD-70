using UnityEngine;
using System.Collections;

public class KillPlayer : MonoBehaviour
{

	public LevelManager levelManager;

	// Use this for initialization
	void Start()
	{
		levelManager = FindObjectOfType<LevelManager>();
	}

	// Update is called once per frame
	void Update()
	{

	}

	void OnTriggerEnter2D(Collider2D other)
	{

		print ("Something entered the collider");
		//If the player goes onto a death box, they die
		if (other.name == "Player")
		{
			print ("Entered the death");
			levelManager.RespawnPlayer();
		}

		//If an enemy goes onto a death box the enemy gets destroyed
		if (other.tag == "Enemy") {

			print ("Enemy entered collider and was destroyed");
			Destroy (other);

		}


	}
}
