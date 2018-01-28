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

    public GameObject menuPanel;
    public int terminalCounter = 0;
    public AudioSource backgroundMusic;

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
        GoToMenu();
    }

    void Update()
    {
        switch (state)
        {
            case StateType.TUTO1 :
                if (terminalCounter == 1)
                {
                    terminalCounter = 0;
                    GoToTuto2();
                }
                break;

            case StateType.TUTO2:
                if (terminalCounter == 1)
                {
                    terminalCounter = 0;
                    GoToTuto3();
                }
                break;

            case StateType.TUTO3:
                if (terminalCounter == 1)
                {
                    terminalCounter = 0;
                    GoToLevel1();
                }
                break;

            case StateType.LEVEL1:
                if (terminalCounter == 4)
                {
                    terminalCounter = 0; 
                    GoToEndDropGame();
                }
                break;

            case StateType.LEVEL2:
                if (terminalCounter == 1)
                {
                    terminalCounter = 0;
                    //GoToEndDropGame();
                }
                break;

            default :
                Debug.Log("default case reached (Update method in menu");
                ResetAll();
                break;
        }
    }

    public void GoToMenu()
    {
        state = StateType.MENU;
        backgroundMusic.Play();
        menuPanel.SetActive(true);
        SceneManager.LoadScene(0);
        Debug.Log("Goto Tuto 1");
    }

    public void GoToTuto1()
    {
        state = StateType.TUTO1;
        menuPanel.SetActive(false);
        SceneManager.LoadScene(1);
        Debug.Log("Play Tuto 1");
    }

    public void GoToTuto2()
    {
        state = StateType.TUTO2;
        StartCoroutine(LoadSceneAfter(2));
        Debug.Log("Play Tuto 2");

    }

    public void GoToTuto3()
    {
        state = StateType.TUTO3;
        StartCoroutine(LoadSceneAfter(3));
        Debug.Log("Play Tuto 3");

    }

    public void GoToLevel1()
    {
        state = StateType.LEVEL1;
        StartCoroutine(LoadSceneAfter(4));
        Debug.Log("Play Level 1");

    }

    public void GoToLevel2()
    {
        state = StateType.LEVEL2;
        StartCoroutine(LoadSceneAfter(5));
        Debug.Log("Play Level 2");
    }
    
    public void GoToEndDropGame()
    {
        backgroundMusic.Stop();
        Debug.Log("dddddddd");
        /********* POUR DAVID
         * 2e JEU
         * **************/
         GameManager.Instance.GoToGame();
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit game");
    }

    public void incrementCount()
    {
        terminalCounter++;
    }

    private void ResetAll()
    {
        Debug.Log("Reset");
        terminalCounter = 0;
    }

    public IEnumerator LoadSceneAfter(int sceneIndex)
    {
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene(sceneIndex);
    }

}
