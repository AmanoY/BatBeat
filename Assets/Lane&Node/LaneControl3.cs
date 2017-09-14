using UnityEngine;
using System.Collections;

public class LaneControl3 : MonoBehaviour
{
    NotesControl3 Destry;
    // Use this for initialization
    void Start()
    {
        Destry = GameObject.FindObjectOfType<NotesControl3>();
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
            Destry.DestroyObject3();
        }
    }
}
