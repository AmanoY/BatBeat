using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

//It's my life Easy譜面
public class NotesGenerator : MonoBehaviour
{
    
    float timer = 0.0f;

    int timeCount = 0;
    public RectTransform clear;

    //Notesを発生させる時間
    public float[] timingEasy =
    {
3.7f,
6.6f,
8.1f,
9.7f,
11.1f,
12.6f,
14.1f,
15.5f,
17f,
18.5f,
20.1f,
21.7f,
23f,
24.6f,
26.1f,
27.6f,
29f,
30.6f,
32.1f,
33.7f,
35f,
36.6f,
38f,
39.6f,
41f,
42.7f,
43.1f,
44.1f,
45.7f,
46f,
47.2f,
49.3f,
50.1f,
50.8f,
51.5f,
52.2f,
53.1f,
53.9f,
54.8f,
57.6f,
60.7f,
63.7f,
66.6f,
67.4f,
68.1f,
68.9f,
69.6f,
70.4f,
71.1f,
71.8f,
72.6f,
74.2f,
75.7f,
77.1f,
78.6f,
80.1f,
81.5f,
83.1f,
84.6f,
85.1f,
86.1f,
87.7f,
88.1f,
89.1f,


    };
    public GameObject notesPrefab;

    private void Start()
    {
       
    }
    // NotesControl1 Notes;



    // Update is called once per frame
    void Update()
    {
        if (GameManager.isPause == true)
        {

            //timerに時間を加算させ続ける
            timer += Time.deltaTime;
            if (GameData.DifficultyChange == 0)
            {
                //EasyのNotesを呼び出す
                for (timeCount = 0; timeCount < timingEasy.Length - 1; timeCount++)
                {

                    if (timingEasy[timeCount] >= timer - Time.deltaTime / 2 && timingEasy[timeCount] <= timer + Time.deltaTime / 2)
                    {

                        GameObject go = Instantiate(notesPrefab);
                    }

                }
            }
            if (timer > 88)
            {
                clear.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 170);
            }
            if (timer >= 90)
            {
                SceneManager.LoadScene("ClearScene");
            }
        }
    }
}
