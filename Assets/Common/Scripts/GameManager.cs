using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager Instance = null;

	private void Awake()
	{
		Instance = this;
	}

	void Start()
	{
		GoToMenu();
	}

	public void GoToMenu()
	{
		SceneManager.LoadScene(0);
	}

	public void GoToGame()
	{
		PrepareLoadLevel(Menu);
		SceneManager.LoadScene(1);
	}
}

//Personnage 1mx1m