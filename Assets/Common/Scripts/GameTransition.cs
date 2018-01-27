using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameTransition : MonoBehaviour {

    static public GameTransition Instance = null;

    private AsyncOperation currentOperation = null;
    private bool isLoading;

	void Awake ()
    {
        // Singleton pattern.
		if (Instance != null)
        {
            Destroy(this.gameObject);
        }
        Instance = this;
        DontDestroyOnLoad(this.gameObject);

        this.isLoading = false;
	}

    // Preload level in background but doesn't transition to level yet.
    public void PrepareLoadLevel(string name)
    {
        // Cancel if already loading something.
        if (this.isLoading) return;

        this.isLoading = true;
        this.currentOperation = SceneManager.LoadSceneAsync(name);
        this.currentOperation.allowSceneActivation = false;
    }

    // Allow to start the transition to the preloaded level if ready.
    public void ActivateLoadLevel() {
        if (this.currentOperation != null) {
            this.currentOperation.allowSceneActivation = true;
            this.isLoading = false;
            this.currentOperation = null;
        }
    }
}
