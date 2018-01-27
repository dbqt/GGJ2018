using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayButton : MonoBehaviour {

	public void GoToGameButton ()
    {
        GameManagementScript.Instance.GoToGame1();
    }
    
}