using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class dropGM : MonoBehaviour {

    public static dropGM instance { get; set; }

    enum StateType
    {
        MENU,
        TUTO1,
        TUTO2,
        TUTO3,
        LEVEL1,
        LEVEL2
    };

    [SerializeField]
    private StateType state;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else 
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        ResetAll();
        state = StateType.MENU;
    }

    public void GoToMenu()
    {
        state = StateType.MENU;
        Debug.Log("Goto Tuto 1");

    }

    public void GoToTuto1()
    {
        state = StateType.TUTO1;
        Debug.Log("Play Tuto 1");
    }

    public void GoToTuto2()
    {
        state = StateType.TUTO2;
        Debug.Log("Play Tuto 2");

    }

    public void GoToTuto3()
    {
        state = StateType.TUTO3;
        Debug.Log("Play Tuto 3");

    }

    public void GoToLevel1()
    {
        state = StateType.LEVEL1;
        Debug.Log("Play Level 1");

    }

    public void GoToLevel2()
    {
        state = StateType.LEVEL2;

        Debug.Log("Play Level 2");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit game");
    }

    private void ResetAll()
    {
        Debug.Log("Reset");
    }

}
