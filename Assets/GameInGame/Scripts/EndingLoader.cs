using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingLoader : MonoBehaviour {

	// Use this for initialization
	void OnEnable () {
		GameManager.Instance.GoToMenu();
        GameTransition.Instance.ActivateLoadLevel();
	}
	
}
