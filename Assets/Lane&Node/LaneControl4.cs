using UnityEngine;
using System.Collections;

public class LaneControl4 : MonoBehaviour {
    NotesControl4 Destry;
    // Use this for initialization
    void Start()
    {
        Destry = GameObject.FindObjectOfType<NotesControl4>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("判定あり");
        if (Input.GetMouseButtonDown(0))
        {
            Destry.DestroyObject4();
        }
    }
}
