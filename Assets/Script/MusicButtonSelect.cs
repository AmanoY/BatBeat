using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// ミュージックシーン選曲
/// </summary>

public class MusicButtonSelect : MonoBehaviour {

    //画像配列
    public RectTransform[] musicSelect;

    //移動したい値
    float offset = 500f;

    public int tapCount = 0;

    public int tapChangeCount = 0;

    //左に移動
    public void MusicMoveL()
    {
        if (tapCount >= 0 && tapCount < musicSelect.Length - 1)
        {
            for (int i = 0; i < musicSelect.Length; i++)
            {
                musicSelect[i].anchoredPosition += new Vector2(-offset, 0f);
            }
            tapCount++;
        }
    }

    //右に移動
    public void MusicMoveR()
    {
        if (tapCount > 0 && tapCount <= musicSelect.Length)
        {
            for (int i = 0; i < musicSelect.Length; i++)
            {
                musicSelect[i].anchoredPosition += new Vector2(offset, 0f);
            }
            tapCount--;
        }
    }



    void Start () {
	
	}
	

	void Update () {
	
	}
}
