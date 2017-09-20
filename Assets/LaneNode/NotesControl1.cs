using UnityEngine;
using System.Collections;

public class NotesControl1 : MonoBehaviour {
    
    Vector3 InitialPosition = new Vector3(0, 0, 0);
    float xspeed = 0,yspeed = 0;
    int randomVec = 0;
    float scale = 0;
    public GameObject gameManager;

    // Use this for initialization
    void Start()
    {
        transform.position = InitialPosition;//初期位置にする
        randomVec = Random.Range(0, 4);
        switch (3)
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
        Debug.Log(2);
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
}
