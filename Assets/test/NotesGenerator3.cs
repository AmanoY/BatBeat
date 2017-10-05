using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NotesGenerator3 : MonoBehaviour
{


    float timer = 0.0f;

    int timeCount = 0;
    public RectTransform clear;

    bool Chain;

    NotesGenerator difficulty;
    public SceneChange sceneChange;
    public GameObject notesPrefab;

    int Timer;

    public float[] ReaperEasy =

     {
2.7f,
5.6f,
7.1f,
8.7f,
10.1f,
11.6f,
13.1f,
14.5f,
16f,
17.5f,
19.1f,
20.7f,
22f,
23.6f,
25.1f,
26.6f,
28f,
29.6f,
31.1f,
32.7f,
34f,
35.6f,
37f,
38.6f,
40f,
41.7f,
42.1f,
43.1f,
44.7f,
45f,
46.2f,
48.3f,
49.1f,
49.8f,
50.5f,
51.2f,
52.1f,
52.9f,
53.8f,
56.6f,
59.7f,
62.7f,
65.6f,
66.4f,
67.1f,
67.9f,
68.6f,
69.4f,
70.1f,
70.8f,
71.6f,
73.2f,
74.7f,
76.1f,
77.6f,
79.1f,
80.5f,
82.1f,
83.6f,
84.1f,
85.1f,
86.7f,
87.1f,
88.1f,
89.1f,






    };
    // Use this for initialization
    void Start()
    {
        Chain = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.isPause == true)
        {
            //timerに時間を加算させ続ける
            timer += Time.deltaTime;
            //if (timer >= 4 && (Chain))
            //{
            //    GetComponent<AudioSource>().Play();
            //    Chain = false;
            //}
            if (GameData.DifficultyChange == 0)
            {
                //EasyのNotesを呼び出す
                for (timeCount = 0; timeCount < ReaperEasy.Length - 1; timeCount++)
                {

                    if (ReaperEasy[timeCount] >= timer - Time.deltaTime / 2 && ReaperEasy[timeCount] <= timer + Time.deltaTime / 2)
                    {

                        GameObject go = Instantiate(notesPrefab);
                    }

                }
            }
            if (timer > 96)
            {
                clear.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 170);
            }
            if (timer >= 98)
            {
                SceneManager.LoadScene("ClearScene");
            }
        }
    }
}

