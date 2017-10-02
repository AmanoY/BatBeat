using UnityEngine;
using System.Collections;
using System;

public class TouchManager : MonoBehaviour
{
    bool touched=false;
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

    GameObject[] StayNorts=new GameObject[256];

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
        if (Input.GetKeyUp(KeyCode.F) && transform.name == "Button1")
        {
            touched = false;
        }

        if (Input.GetKeyDown(KeyCode.J) && transform.name == "Button2")
        {
            touched = true;
        }
        if (Input.GetKeyUp(KeyCode.J) && transform.name == "Button2")
        {
            touched = false;
        }

        if (Input.GetKeyDown(KeyCode.V) && transform.name == "Button3")
        {
            touched = true;
        }
        if (Input.GetKeyUp(KeyCode.V) && transform.name == "Button3")
        {
            touched = false;
        }

        if (Input.GetKeyDown(KeyCode.N) && transform.name == "Button4")
        {
            touched = true;
        }
        if (Input.GetKeyUp(KeyCode.N) && transform.name == "Button4")
        {
            touched = false;
        }

        if (touched)
        {
            GameObject nearestNorts=new GameObject();
            foreach (GameObject go in GameObject.FindGameObjectsWithTag(gameObject.tag))
            {
                //タグをもつものが自分自身ではないとき
                if (go!=gameObject)
                {
                    if (nearestNorts)
                    {
                        //現在最も近いNotesよりも今回のNotesの方が近ければ更新
                        if (Vector3.Distance(this.transform.position,nearestNorts.transform.position)>Vector3.Distance(this.transform.position,go.transform.position))
                        {
                            nearestNorts = go;
                        }
                    }else
                    {
                        //まだなにも登録されていなければ無条件で最も近いNotesとする
                        nearestNorts = go;
                    }
                }
            }
            //最も近いNotesを削除
            dir = nearestNorts.transform.position - transform.position;
            float d = dir.magnitude;
            if (d <= 1.0f)
            {
                perfectEffect.Play();
                GetComponent<AudioSource>().Play();
                Destroy(nearestNorts);
                gameManeger.PerfectComboCount();

            }
            else if (d <= 3.0f)
            {
                goodEffect.Play();
                GetComponent<AudioSource>().Play();
                Destroy(nearestNorts);
                gameManeger.GoodComboCount();
            }
            else if (d <= 6.0f)
            {
                missEffect.Play();
                Destroy(nearestNorts);
                gameManeger.MissComboCount();
            }
            touched = false;
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

