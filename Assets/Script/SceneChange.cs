using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// 汎用シーン遷移クラス
/// </summary>
public class SceneChange : MonoBehaviour
{
    //もしボタン発動時にSE鳴らしたいならお使いください
    //public AudioSource ButtonSound;


    //シーンを名前で飛ばす用
    public void NextSceneName(string sceneName)
    {
        //もしボタン発動時にSE鳴らしたいならお使いください
        //ButtonSound.PlayOneShot(rankingButtonSound.clip);

        SceneManager.LoadScene(sceneName);

    }

    //シーンを数字で飛ばす用
    public void NextSceneNumber(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }

    private void Start()
    {
        //もしボタン発動時にSE鳴らしたいならお使いください
        //ButtonSound = GetComponent<AudioSource>();
    }
}
