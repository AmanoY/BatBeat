using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoGameandBackScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    public void GoGameScene() {
            SceneManager.LoadScene("GameScene1");

    }
    public void BackButtonPush() {
        SceneManager.LoadScene("SelectScene");
    }
}
