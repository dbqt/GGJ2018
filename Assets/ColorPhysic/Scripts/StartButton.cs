using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayButton : MonoBehaviour {

	public void GoToGameButton ()
    {
        GameManager.Instance.GoToGame();
    }
    
}