using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausePanel : MonoBehaviour
{
    GameManager gameManager;

    bool isVisible;



    AudioSource menuButtonSound;

    public void ToggleShow()
    {
            if (isVisible)
            {
                Hide();
                GameManager.isPause = true;
            }
            else
            {
                GameManager.isPause = false;
                isVisible = true;
                GetComponent<RectTransform>().anchoredPosition = new Vector2(0,410);
            }
        
    }

    public void Hide()
    {
        GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 2000);
        isVisible = false;

    }
    public void BackButton()
    {
        Debug.Log("バックボタンおされた");
        menuButtonSound.PlayOneShot(menuButtonSound.clip);
        GameManager.isPause = false;
        Hide();
    }

    public void RetireButton()
    {
        Debug.Log("リタイアボタンおされた");
        menuButtonSound.PlayOneShot(menuButtonSound.clip);
        Invoke("LoadSelectScene", 0.5f);
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
