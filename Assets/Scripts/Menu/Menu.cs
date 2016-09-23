using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour
{


	public string levelToLoad;

	void Start()
	{
		
	}

	public void OnStart()
	{
		Application.LoadLevel(levelToLoad);
	}

	public void Quit()
	{
		Application.Quit();
		Debug.Log("Quit the game.");
	}
}
