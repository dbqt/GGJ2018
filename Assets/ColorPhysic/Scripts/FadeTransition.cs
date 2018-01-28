using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FadeTransition : MonoBehaviour {

    public Image fadeImage;
    public float fadeSpeed;

    public static FadeTransition instance { get; set; }
    
	void Awake () {
		
        if( instance == null )
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
        fadeSpeed = 0.5f;
    }
	
    public void DoTransition()
    {
        StartCoroutine(FadeInFadeOut());
    }

	private IEnumerator FadeInFadeOut()
    {

    }

    private void StopTransition()
    {
        StopAllCoroutines();
    }

}
