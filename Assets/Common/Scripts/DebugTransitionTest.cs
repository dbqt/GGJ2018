using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTransitionTest : MonoBehaviour {

    [SerializeField]
    float Delay = 2f;

    [SerializeField]
    string SceneToLoad;

	// Use this for initialization
	void Start () {
		GameTransition.Instance.PrepareLoadLevel(SceneToLoad);
        ZoomToCenter();

        Invoke("Load", Delay);
	}

    void Load() {
        GameTransition.Instance.ActivateLoadLevel();
    }
}
