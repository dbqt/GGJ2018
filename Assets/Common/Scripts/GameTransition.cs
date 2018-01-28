using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameTransition : MonoBehaviour {

    static public GameTransition Instance = null;

    [SerializeField]
    float ZoomRate;
    [SerializeField]
    float DefaultSize;
    [SerializeField]
    float ZoomedSize;

    private AsyncOperation currentOperation = null;
    private bool isLoading;
    private bool isZooming;

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
        this.isZooming = false;
	}

    void Update() {
        /*if (this.isZooming) {
            Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, ZoomedSize, ZoomRate);
            if (Camera.main.orthographicSize <= ZoomedSize || Camera.main.orthographicSize - ZoomedSize < ZoomRate) {
                ActivateLoadLevel();
            }
        }*/
    }

    // Load the level with transition.
    public void LoadLevel(string name) {
        PrepareLoadLevel(name);
        //ZoomToCenter(true);
    }

    // Preload level in background but doesn't transition to level yet.
    private void PrepareLoadLevel(string name)
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
            //ZoomToCenter(false);
        }
    }

    private void ZoomToCenter(bool enable) {
        this.isZooming = enable;
    }
}
