using UnityEngine;
using System.Collections;

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
        if (OnTouchDown())
        {
            Lane = transform.position;
            Notes = collision.gameObject.transform.position;
            dir = Lane - Notes;
            float d = dir.magnitude;

            //ミスの判定
            //Debug.Log(collision.gameObject.transform.position)
            if (d<=1.4&&d>=1.3)
            {
                Destroy(collision.gameObject);
                gameManeger.MissComboCount();
            }

            //goodの判定
            else if (d<=1.29&&d>=1)
            {
                Destroy(collision.gameObject);
                gameManeger.GoodComboCount();
            }

            //perfectの判定
            else if (d >= 0&&d<=0.99)
            {
                Destroy(collision.gameObject);
                gameManeger.PerfectComboCount();
            }

        }
    }

    /// <summary>
    /// コライダーがクリック（タップ）されたときに呼び出される
    /// </summary>
    private void OnMouseDown()
    {
        //Debug.Log("クリックされた" + gameObject.name);
        //touched = true;

    }

    /// <summary>
    /// タップが終わったときに呼び出される
    /// </summary>
    private void OnMouseUp()
    {
        touched = false;
    }


    bool OnTouchDown()
    {
        // タッチされているとき
        if (0 < Input.touchCount)
        {
            // タッチされている指の数だけ処理
            for (int i = 0; i < Input.touchCount; i++)
            {
                // タッチ情報をコピー
                Touch t = Input.GetTouch(i);
                // タッチしたときかどうか
                if (t.phase == TouchPhase.Began)
                {
                    //タッチした位置からRayを飛ばす
                    Ray ray = Camera.main.ScreenPointToRay(t.position);
                    RaycastHit hit = new RaycastHit();
                    if (Physics.Raycast(ray, out hit))
                    {
                        //Rayを飛ばしてあたったオブジェクトが自分自身だったら
                        if (hit.collider.gameObject == this.gameObject)
                        {
                            return true;
                        }
                    }
                }
            }
        }
        return false; //タッチされてなかったらfalse
    }

    // Use this for initialization
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {


    }
}
