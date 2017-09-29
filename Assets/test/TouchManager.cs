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

    public ParticleSystem perfectEffect;
    public ParticleSystem goodEffect;
    public ParticleSystem missEffect;

    public void OnTriggerStay2D(Collider2D collision)
    {

        //押している最中は削除
        if (touched)
        {
            Lane = transform.position;
            Notes = collision.gameObject.transform.position;
            dir = Notes - Lane;
            float d = dir.magnitude;
            if ( d <= 1.0f)
            {
                perfectEffect.Play();
                GetComponent<AudioSource>().Play();
                Destroy(collision.gameObject);
                gameManeger.PerfectComboCount();
                
            }
            else if( d <= 3.0f )
            {
                goodEffect.Play();
                GetComponent<AudioSource>().Play();
                Destroy(collision.gameObject);
                gameManeger.GoodComboCount();
            }
            else if( d<=6.0f)
            {
                missEffect.Play();
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
        NodePre = GameObject.Find("NotesObjectPrefab 1");
       // perfect.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && transform.name == "Button1")
        {
            touched = true;
        }

        if (Input.GetKeyDown(KeyCode.J) && transform.name == "Button2")
        {
            touched = true;

        }

        if (Input.GetKeyDown(KeyCode.V) && transform.name == "Button3")
        {
            touched = true;

        }

        if (Input.GetKeyDown(KeyCode.N) && transform.name == "Button4")
        {
            touched = true;

        }
    }
    public void TouchButtonDown()
    {
        touched = true;
    }
    public void TouchButtonUp()
    {
        touched = false;
    }
    public void KeychordDown()
    {
        touched = true;
    }
    public void KeychordUp()
    {
        touched = false;
    }
}

