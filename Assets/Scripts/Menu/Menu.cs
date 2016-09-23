using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{

	public Text completion;

	public string levelToLoad;

	void Start()
	{
		completion.text = "Completed " + PlayerPrefs.GetInt("CompletedTimes") + " Times!";
	}

	public void OnStart()
	{
		Application.LoadLevel(levelToLoad);
		PlayerPrefs.SetInt ("PlayerLevel", 1);
	}

	public void Quit()
	{
		Application.Quit();
		Debug.Log("Quit the game.");
	}

	public void Continue(){

		if (PlayerPrefs.GetInt ("PlayerLevel") == 0) {

			Application.LoadLevel ("Level1");

		} else {
			Application.LoadLevel ("Level" + PlayerPrefs.GetInt ("PlayerLevel"));
			print ("Level" + PlayerPrefs.GetInt ("PlayerLevel"));
		}
	}
}
