using UnityEngine;
using System.Collections;

public class NotesControl1 : MonoBehaviour {
    
    Vector3 InitialPosition = new Vector3(0, 0, 0);
    float xspeed = 0,yspeed = 0;
    int randomVec = 0;
    float scale = 0;
    GameManager gameManager;
    static bool[] useLaneFlg = { false, false, false, false };
    int timeCount;
    float timing;
   // NotesGenerator notesGenerator;
    //GameObject notesGenerator;

    // Use this for initialization
    void Start()
    {
        //notesGenerator = GetComponent<NotesGenerator>();
        //notesGenerator = GameObject.Find("NotesGenerator").GetComponent<NotesGenerator>();
        //timeCount = notesGenerator.timeCount;
        //timing = notesGenerator.timing;
        gameManager = GetComponent<GameManager>();
        transform.position = InitialPosition;//初期位置にする

        // Laneの使用状況初期化
        //if (notesGenerator.TimingCheck() == false)
        //{
        //    for (int i = 0; i < 4; i++)
        //    {
        //        useLaneFlg[i] = false;
        //    }
        //}

        // Notes出現位置ランダム設定
        randomVec = Random.Range(0, 4);

        // ランダム指定位置がすでに同じタイミングで他のNotesが使用しているかチェック
        //while (useLaneFlg[randomVec])
        //{
        //    // Notes使用中のためもう一度ランダム
        //    randomVec = Random.Range(0, 4);
        //}

        // 現在の指定位置を使用中に変更
        //useLaneFlg[randomVec] = true;

        switch (randomVec)
        {
            case 0:
                UpperLeft();
                break;
            case 1:
                UpperRight();
                break;
            case 2:
                BottomLeft();
                break;
            case 3:
                BottomRight();
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(xspeed,yspeed, 0.0f);     //左上
        //transform.Translate(-0.1f, 0.05f, 0.0f);     //左上
        if (transform.position.x > 10.0f || transform.position.x < -10.0f)
        {
            GameData.misscombo++;
            GameManager.ComboCount = 0;
            Destroy(gameObject);    //画面外に出たら消す
        }
            scale += 0.018f;
        if (scale>=1)
        {
            scale = 1;
        }
        transform.localScale = new Vector3(scale,scale , 0);
        
    }

    //左上に進むメソッド
    public void UpperLeft()
    {
        //Debug.Log(1);
        xspeed = -0.1f;
        yspeed = 0.05f;

    }

    //右上に進むクラス
    public void UpperRight()
    {

        xspeed = 0.1f;
        yspeed = 0.05f;
    }

    //左下に進むクラス
    public void BottomLeft()
    {
        xspeed = -0.1f;
        yspeed = -0.05f;
    }

    //右下に進むクラス
    public void BottomRight()
    {
        xspeed = 0.1f;
        yspeed = -0.05f;
    }

    //public bool TimingCheck()
    //{
    //    if (timeCount > 0)
    //    {
    //        if (timing[timeCount] == timing[timeCount - 1])
    //        {
    //            return true;
    //        }
    //    }
    //    return false;
    //}
}
