using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        SceneManager.LoadScene(levelToLoad);
		PlayerPrefs.SetInt ("PlayerLevel", 1);
	}

	public void Quit()
	{
		Application.Quit();
		Debug.Log("Quit the game.");
	}

	public void Continue(){

		if (PlayerPrefs.GetInt ("PlayerLevel") == 0) {

            SceneManager.LoadScene("Level1");

		} else {
            SceneManager.LoadScene("Level" + PlayerPrefs.GetInt("PlayerLevel"));
			print ("Level" + PlayerPrefs.GetInt ("PlayerLevel"));
		}
	}

    public void toMainMenu()
    {

        SceneManager.LoadScene("Menu");

    }
}
