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
5.4f,
5.8f,
6.2f,
6.6f,
7f,
7.3f,
7.7f,
8.1f,
8.5f,
8.9f,
9.2f,
9.6f,
9.9f,
10.3f,
10.7f,
11.1f,
11.5f,
11.9f,
12.2f,
12.6f,
13f,
13.3f,
13.7f,
14.1f,
14.5f,
14.9f,
15.3f,
15.6f,
16f,
16.4f,
16.8f,
17.1f,
17.5f,
17.9f,
18.2f,
18.6f,
18.9f,
19.3f,
19.7f,
20.1f,
20.5f,
20.8f,
21.2f,
21.6f,
21.9f,
22.3f,
22.6f,
23f,
23.4f,
24.2f,
24.6f,
24.9f,
25.3f,
25.7f,
26.1f,
26.4f,
26.8f,
27.2f,
27.5f,
27.9f,
28.3f,
28.7f,
29.1f,
29.5f,
29.8f,
30.2f,
30.9f,
31.2f,
31.6f,
32f,
32.4f,
32.8f,
33.2f,
33.5f,
33.9f,
34.7f,
34.9f,
35.1f,
35.3f,
35.5f,
35.6f,
35.8f,
36f,
36.2f,
36.4f,
36.6f,
36.8f,
37f,
37.2f,
37.4f,
37.8f,
39.2f,
40f,
40.7f,
40.9f,
41.1f,
41.3f,
41.5f,
41.6f,
41.8f,
42f,
42.2f,
42.4f,
42.6f,
42.8f,
43f,
43.2f,
43.4f,
43.5f,
43.8f,
44.5f,
45.2f,
45.9f,
46.7f,
47.1f,
47.5f,
47.6f,
47.8f,
48.2f,
48.5f,
48.7f,
48.9f,
49.1f,
49.3f,
49.5f,
49.7f,
50.1f,
50.5f,
50.6f,
50.8f,
51.2f,
52.8f,
53.1f,
53.5f,
53.9f,
54.2f,
54.6f,
55f,
56.3f,
55.7f,
55.8f,
56.5f,
56.8f,
57.2f,
57.5f,
57.9f,
58.3f,
58.7f,
59.1f,
59.5f,
59.8f,
60.2f,
60.5f,
60.9f,
61.3f,
61.7f,
62f,
62.4f,
62.7f,
63.1f,
63.5f,
63.9f,
64.2f,
64.7f,
65f,
65.4f,
65.8f,
66.2f,
66.6f,
66.9f,
67.3f,
67.7f,
68.1f,
68.5f,
68.8f,
69.2f,
69.6f,
70f,
70.4f,
70.8f,
71.1f,
71.5f,
71.9f,
72.2f,
72.6f,
72.9f,
73.3f,
73.7f,
74.1f,
74.3f,
74.8f,
75.2f,
75.6f,
76f,
76.4f,
76.8f,
76.8f,
77.2f,
77.5f,
77.7f,
77.9f,
78.2f,
78.4f,
78.6f,
78.8f,
79f,
79.2f,
79.4f,
79.5f,
79.8f,
80.1f,
80.5f,
80.8f,
81.2f,
81.6f,
82f,
82.4f,
82.8f,
82.9f,
83.1f,
83.3f,
83.7f,
83.9f,
84.1f,
84.3f,
84.5f,
84.7f,
84.9f,
85f,
85.2f,
85.4f,
85.6f,
85.8f,
86.5f,
86.9f,
87.3f,
87.6f,
88f,
88.4f,
88.7f,
89.1f,
89.2f,
89.4f,
89.9f,
90.2f,
90.6f,
90.8f,
91f,
91.2f,
91.4f,
91.6f,
91.8f,
92.5f,
92.6f,
92.8f,
93f,


    };


    // Use this for initialization
    void Start()
    {
        Chain = true;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 4 && (Chain))
        {
            GetComponent<AudioSource>().Play();
            Chain = false;
        }
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
