﻿using UnityEngine;
using System.Collections;

public class LevelUp : MonoBehaviour {

	public LevelManager levelManager;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.name == "Player")
		{
			levelManager.NextLevel();
		}
	}
}
