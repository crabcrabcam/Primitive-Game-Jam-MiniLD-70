using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour
{

	public bool isPaused;
	public GameObject pauseMenuCanvas;

	void Update()
	{

		if (Input.GetKeyDown(KeyCode.Escape))
		{
			isPaused = !isPaused;
		}

		if (isPaused)
		{
			pauseMenuCanvas.SetActive(true);
			Time.timeScale = 0f;
		}
		else
		{
			pauseMenuCanvas.SetActive(false);
			Time.timeScale = 1f;
		}



	}

	public void Resume()
	{
		isPaused = false;
	}

	public void MainMenu()
	{
		Application.LoadLevel("Menu");
	}

	public void RestartLevel()
	{
		Application.LoadLevel (Application.loadedLevel);
	}

	public void Quit()
	{
		Application.Quit();
		Debug.Log("Quit the game.");
	}
}
