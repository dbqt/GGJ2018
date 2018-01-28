using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GoToMainMenuButton : MonoBehaviour {


	public void GoToMainMenu()
    {
        //SceneManager.LoadScene(0);
        GameManager.Instance.GoToMenu();
    }

}