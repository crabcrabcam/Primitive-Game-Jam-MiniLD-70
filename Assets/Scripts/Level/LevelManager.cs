using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public string levelToLoad;

	public GameObject currentCheckpoint;

	public PlayerMovement player;

	public int levelNumber;

    public bool lastLevel = false;

	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("PlayerLevel", levelNumber);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void RespawnPlayer()
	{
		Debug.Log("Player Respawn");
		player.transform.position = currentCheckpoint.transform.position;
	}


	public void NextLevel()
	{

        if (lastLevel)
        {
            PlayerPrefs.SetInt("CompletedTimes", PlayerPrefs.GetInt("CompletedTimes") + 1);
            SceneManager.LoadScene("Completed");
            PlayerPrefs.SetInt("PlayerLevel", 1);
        }
        else
        {
            Debug.Log("Level Up!");
            SceneManager.LoadScene(levelToLoad);
        }
		
	}
}
