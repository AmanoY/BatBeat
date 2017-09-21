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

    // Use this for initialization
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {

    }
}
