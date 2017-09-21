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
        if (touched)
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

            touched = false;
        }
    }

    /// <summary>
    /// コライダーがクリック（タップ）されたときに呼び出される
    /// </summary>
    private void OnMouseDown()
    {
        //Debug.Log("クリックされた" + gameObject.name);
        touched = true;

    }

    /// <summary>
    /// タップが終わったときに呼び出される
    /// </summary>
    private void OnMouseUp()
    {
        touched = false;
    }


    public void RangeDetection()
    {
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
