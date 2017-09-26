using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BackButtontoMusicSelect : MonoBehaviour {
    SceneChange sceneChange;
    GameManager gameManager;
    void Start()
    {
        sceneChange = GameObject.FindObjectOfType<SceneChange>();
        gameManager = GetComponent<GameManager>();
        gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            sceneChange.NextSceneNumber(3);
            gameManager.ResetGame();
        }
    }
    public void TouchButtonPush(){
        SceneManager.LoadScene("MusicSelectScene");
    }
}
