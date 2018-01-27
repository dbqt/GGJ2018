using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTransitionTest : MonoBehaviour {
    [SerializeField]
    string SceneToLoad;

	void Start () {
		GameTransition.Instance.LoadLevel(SceneToLoad);
	}
}