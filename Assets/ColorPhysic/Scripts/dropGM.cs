using System.Collections;
using System.Collections.Generic;
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

    void GoToMenu()
    {

    }

    void GoToTuto1()
    {

    }

    void GoToTuto2()
    {

    }

    void GoToTuto3()
    {

    }
    
    void GoToLevel1()
    {

    }

    void GoToLevel2()
    {

    }

    void ResetAll()
    {
    }
}
