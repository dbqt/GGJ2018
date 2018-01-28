using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class FadeTransition : MonoBehaviour {

    public Image fadeImage;
    public Animator anim;

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


    public void FadeInOnly()
    {

    }
	
    public void FadeToScene(int sceneIndex)
    {
        Debug.Log("Start Fading");
        StartCoroutine(FadeIn(sceneIndex));
    }
    
	private IEnumerator FadeIn(int sceneIndex)
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => fadeImage.color.a == 1);
        SceneManager.LoadScene(1);
       
    }
    private void StopTransition()
    {
        StopAllCoroutines();
    }

}
