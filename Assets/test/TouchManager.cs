using UnityEngine;
using System.Collections;
using System;

public class TouchManager : MonoBehaviour
{
    bool touched;
    public GameObject NodePre;
    public GameManager gameManeger;
     Vector2 Lane;
     Vector2 Notes;
     Vector2 dir;
    float d;
    int Count = 0;

    private void OnTriggerStay2D(Collider2D collision)
    {
        
        //押している最中は削除
        if (touched)
        {
            Lane = transform.position;
            Notes = gameObject.transform.position;
            dir = Lane - Notes;
            float d = dir.magnitude;


            if ( d <= 1.0f)
            {
                Debug.Log(d);
                Destroy(collision.gameObject);
                gameManeger.PerfectComboCount();
            }
            else if( d <= 3.0f )
            {
                Debug.Log(d);
                Destroy(collision.gameObject);
                gameManeger.GoodComboCount();
            }
            else if( d<=6.0f)
            {
                Debug.Log(d);
                Destroy(collision.gameObject);
                gameManeger.MissComboCount();
            }
            touched = false;
        }
    }

    /// <summary>
    /// コライダーがクリック（タップ）されたときに呼び出される
    /// </summary>
     /*
    private void OnMouseDown()
    {
        //Debug.Log("クリックされた" + gameObject.name);
        touched = true;

    }
    */

    /// <summary>
    /// タップが終わったときに呼び出される
    /// </summary>
    private void OnMouseUp()
    {
        touched = false;
    }



    // Use this for initialization
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {
        if(IsTouchObject(gameObject))
        {
            touched = true;
        }
        //if (Input.touchCount>0)
        //{
        //    Debug.Log("たっちされたよ");
        //    Touch touch1 = Input.GetTouch(0);
        //    if (touch1.phase==TouchPhase.Began)
        //    {
        //        Debug.Log("x"+touch1.position.x);
        //        Debug.Log("y" + touch1.position.y);
        //        if (touch1.position.x<=-3&&touch1.position.x>=-9
        //            &&touch1.position.y>=2&&touch1.position.y<=4)
        //        {
        //            Debug.Log("判定はできてるよ");
        //            touched = true;
        //        }
            
        //    }
        //    Touch touch2 = Input.GetTouch(1);
        //    if (touch2.phase == TouchPhase.Began)
        //    {

        //    }
        //    Touch touch3 = Input.GetTouch(2);
        //    if (touch3.phase == TouchPhase.Began)
        //    {

        //    }
        //    Touch touch4 = Input.GetTouch(3);
        //    if (touch4.phase == TouchPhase.Began)
        //    {

        //    }
        //}
    }
    // 引数のオブジェクトとタッチの当たり判定メソッド
    public static bool IsTouchObject(GameObject _gameObj)
    {
        // 画面タッチされた？
        for (int i = 0; i < Input.touchCount; ++i)
        {
            Touch touch = Input.touches[i];

            // タッチされた瞬間？
            if (touch.phase == TouchPhase.Began)
            {
                // マウスのタッチ座標をワールド座標に変換
                Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                // タッチ座標を全て取得
                Collider2D[] colliders = Physics2D.OverlapPointAll(pos);

                // 判定したい当たり判定を持っているオブジェクトのID取得
                int enemyID = _gameObj.gameObject.GetInstanceID();

                // タッチ数分チェックする
                foreach (Collider2D collider in colliders)
                {
                    // コライダーのID取得
                    int colliderID = collider.gameObject.GetInstanceID();

                    // 両方のIDログ表示
                    //Debug.Log("enemyID:" + enemyID);
                    //Debug.Log("colliderID:" + colliderID);

                    // IDは同じ？
                    if (enemyID == colliderID)
                    {
                        // 当ててんのよ
                        Debug.Log("当たってる");
                        return true;
                    }
                }
            }

        }
        return false;
    }
}

