using UnityEngine;
using System.Collections;

public class KeyCode1 : MonoBehaviour {

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

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            touched = true;
        }
        if (Input.GetKey(KeyCode.F))
        {
            touched = false;
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            touched = false;
        }

        if (touched)
        {

            Lane = transform.position;
            Notes = NodePre.gameObject.gameObject.transform.position;
            dir = Notes - Lane;
            float d = dir.magnitude;
            Debug.Log(d);
            if (d <= 1.0f)
            {
                perfectEffect.Play();
                GetComponent<AudioSource>().Play();
                Debug.Log(d);
                Destroy(NodePre.gameObject);
                gameManeger.PerfectComboCount();

            }
            else if (d <= 3.0f)
            {
                goodEffect.Play();
                GetComponent<AudioSource>().Play();
                Debug.Log(d);
                Destroy(NodePre.gameObject);
                gameManeger.GoodComboCount();
            }
            else if (d <= 6.0f)
            {
                missEffect.Play();
                Destroy(NodePre.gameObject);
                gameManeger.MissComboCount();
            }
            touched = false;
        }

    }


    public void OnTriggerStay2D(Collider2D collision)
    {
    }
}
