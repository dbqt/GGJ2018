using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager Instance = null;
	public string Menu, Main;

	private void Awake()
	{
		Instance = this;
	}

	void Start()
	{
		//GoToMenu();
	}

	public void GoToMenu()
	{
		//SceneManager.LoadLevel(Menu);
		dropGM.instance.GoToMenu();
		GameTransition.Instance.LoadLevel(Menu); //Menu.unity in ColorPhysic
	}

	public void GoToGame()
	{
		GameTransition.Instance.LoadLevel(Main); //Main.unity in GameInGame
	}
}

//Personnage 1mx1m