using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

//呪いの館Normal譜面
public class NotesGenerator4 : MonoBehaviour {

    float timer = 0.0f;

    int timeCount = 0;

    bool Chain;
    public RectTransform clear;

    NotesGenerator difficulty;
    public SceneChange sceneChange;
    public GameObject notesPrefab;

    public float[] timingNormal = 
    {
1.5f,
1.9f,
2.3f,
2.7f,
3.1f,
3.4f,
3.8f,
4.2f,
4.6f,
5f,
5.3f,
5.7f,
6f,
6.4f,
6.8f,
7.2f,
7.6f,
8f,
8.3f,
8.7f,
9.1f,
9.4f,
9.8f,
10.2f,
10.6f,
11f,
11.4f,
11.7f,
12.1f,
12.5f,
12.9f,
13.2f,
13.6f,
14f,
14.3f,
14.7f,
15f,
15.4f,
15.8f,
16.2f,
16.6f,
16.9f,
17.3f,
17.7f,
18f,
18.4f,
18.7f,
19.1f,
19.5f,
20.3f,
20.7f,
21f,
21.4f,
21.8f,
22.2f,
22.5f,
22.9f,
23.3f,
23.6f,
24f,
24.4f,
24.8f,
25.2f,
25.6f,
25.9f,
26.3f,
27f,
27.3f,
27.7f,
28.1f,
28.5f,
28.9f,
29.3f,
29.6f,
30f,
30.8f,
31f,
31.2f,
31.4f,
31.6f,
31.7f,
31.9f,
32.1f,
32.3f,
32.5f,
32.7f,
32.9f,
33.1f,
33.3f,
33.5f,
33.9f,
35.3f,
36.1f,
36.8f,
37f,
37.2f,
37.4f,
37.6f,
37.7f,
37.9f,
38.1f,
38.3f,
38.5f,
38.7f,
38.9f,
39.1f,
39.3f,
39.5f,
39.6f,
39.9f,
40.6f,
41.3f,
42f,
42.8f,
43.2f,
43.6f,
43.7f,
43.9f,
44.3f,
44.6f,
44.8f,
45f,
45.2f,
45.4f,
45.6f,
45.8f,
46.2f,
46.6f,
46.7f,
46.9f,
47.3f,
48.9f,
49.2f,
49.6f,
50f,
50.3f,
50.7f,
51.1f,
52.4f,
51.8f,
51.9f,
52.6f,
52.9f,
53.3f,
53.6f,
54f,
54.4f,
54.8f,
55.2f,
55.6f,
55.9f,
56.3f,
56.6f,
57f,
57.4f,
57.8f,
58.1f,
58.5f,
58.8f,
59.2f,
59.6f,
60f,
60.3f,
60.8f,
61.1f,
61.5f,
61.9f,
62.3f,
62.7f,
63f,
63.4f,
63.8f,
64.2f,
64.6f,
64.9f,
65.3f,
65.7f,
66.1f,
66.5f,
66.9f,
67.2f,
67.6f,
68f,
68.3f,
68.7f,
69f,
69.4f,
69.8f,
70.2f,
70.4f,
70.9f,
71.3f,
71.7f,
72.1f,
72.5f,
72.9f,
72.9f,
73.3f,
73.6f,
73.8f,
74f,
74.3f,
74.5f,
74.7f,
74.9f,
75.1f,
75.3f,
75.5f,
75.6f,
75.9f,
76.2f,
76.6f,
76.9f,
77.3f,
77.7f,
78.1f,
78.5f,
78.9f,
79f,
79.2f,
79.4f,
79.8f,
80f,
80.2f,
80.4f,
80.6f,
80.8f,
81f,
81.1f,
81.3f,
81.5f,
81.7f,
81.9f,
82.6f,
83f,
83.4f,
83.7f,
84.1f,
84.5f,
84.8f,
85.2f,
85.3f,
85.5f,
86f,
86.3f,
86.7f,
86.9f,
87.1f,
87.3f,
87.5f,
87.7f,
87.9f,
88.6f,
88.7f,
88.9f,
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
            timer += Time.deltaTime;
            //if (timer >= 4 && (Chain))
            //{
            //    GetComponent<AudioSource>().Play();
            //    Chain = false;
            //}
            //NormalのNotesを呼び出す
            if (GameData.DifficultyChange == 1)
            {
                //EasyのNotesを呼び出す
                for (timeCount = 0; timeCount < timingNormal.Length - 1; timeCount++)
                {

                    if (timingNormal[timeCount] >= timer - Time.deltaTime / 2.0f && timingNormal[timeCount] <= timer + Time.deltaTime / 2.0f)
                    {
                        Debug.Log("timingNormal[timeCount]" + timingNormal[timeCount] + "| timer" + timer + "| Time.deltaTime / 2.0f" + Time.deltaTime / 2.0f);
                        //Debug.Log("timingNormal[timeCount]" + timingNormal[timeCount] + "| timer" + timer + "| Time.deltaTime / 2.0f" + Time.deltaTime / 2.0f);
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
