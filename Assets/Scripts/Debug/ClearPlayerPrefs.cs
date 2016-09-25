using UnityEngine;
using System.Collections;

public class ClearPlayerPrefs : MonoBehaviour {

	// Use this for initialization
	void Start () {
        PlayerPrefs.DeleteAll();
        print("Deleted all of the player prefs");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
