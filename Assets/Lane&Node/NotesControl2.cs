using UnityEngine;
using System.Collections;

public class NotesControl2 : MonoBehaviour {
    Vector3 InitialPosition = new Vector3(0, 0, 0);
    // Use this for initialization
    void Start()
    {
        transform.position = InitialPosition;//初期位置にする
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.1f, 0.05f, 0);      //右上

        if (transform.position.x > 10.0f || transform.position.x < -10.0f)
        {
            Destroy(gameObject);    //画面外に出たら消す
        }

    }
    //判定の検出
    public void OnTriggerStay2D(Collider2D collision)
    {
        //縦横のpositionを検出する
        if (transform.position.x <= 5.5 && transform.position.x >= 6.5 && 
            transform.position.y <= 1.0 && transform.position.y >= 4.0)
        {
            //perfectの判定
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("perfect2");
                Destroy(gameObject);
            }
        }

        if (transform.position.x <= 4.5 && transform.position.x >= 5.49 && 
            transform.position.y <= 1.0 && transform.position.y >= 4.0)
        {
            //goodの判定
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("good2");
                Destroy(gameObject);
            }
        }
        
        if (transform.position.x <= 3.5 && transform.position.x >= 4.49 && 
            transform.position.y <= 1.0 && transform.position.y >= 4.0)
        {
            //Missの判定
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("ミス2");
                Destroy(gameObject);
            }
        }
        
    }
}
