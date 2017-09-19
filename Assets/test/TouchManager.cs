using UnityEngine;
using System.Collections;

public class TouchManager : MonoBehaviour
{
    bool touched;
    public GameObject NodePre;
    private void OnTriggerStay2D(Collider2D collision)
    {
        
        //押している最中は削除
        if (touched)
        {
            Destroy(collision.gameObject);
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
        Vector2 p1=transform
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
