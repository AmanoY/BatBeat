﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NotesGenerator4 : MonoBehaviour {

    float timer = 0.0f;

    int timeCount = 0;

    bool Chain;

    NotesGenerator difficulty;
    public SceneChange sceneChange;
    public GameObject notesPrefab;

    public float[] timingNormal = 
    {
4.7f,
5.3f,
5.7f,
6.1f,
6.5f,
6.9f,
7.2f,
7.6f,
8f,
8.4f,
8.8f,
9.1f,
9.5f,
9.8f,
10.2f,
10.6f,
11f,
11.4f,
11.8f,
12.1f,
12.5f,
12.9f,
13.2f,
13.6f,
14f,
14.4f,
14.8f,
15.2f,
15.5f,
15.9f,
16.3f,
16.7f,
17f,
17.4f,
17.8f,
18.1f,
18.5f,
18.8f,
19.2f,
19.6f,
20f,
20.4f,
20.7f,
21.1f,
21.5f,
21.8f,
22.2f,
22.5f,
22.9f,
23.3f,
24.1f,
24.5f,
24.8f,
25.2f,
25.6f,
26f,
26.3f,
26.7f,
27.1f,
27.4f,
27.8f,
28.2f,
28.6f,
29f,
29.4f,
29.7f,
30.1f,
30.8f,
31.1f,
31.5f,
31.9f,
32.3f,
32.7f,
33.1f,
33.4f,
33.8f,
34.6f,
34.8f,
35f,
35.2f,
35.4f,
35.5f,
35.7f,
35.9f,
36.1f,
36.3f,
36.5f,
36.7f,
36.9f,
37.1f,
37.3f,
37.7f,
39.1f,
39.9f,
40.6f,
40.8f,
41f,
41.2f,
41.4f,
41.5f,
41.7f,
41.9f,
42.1f,
42.3f,
42.5f,
42.7f,
42.9f,
43.1f,
43.3f,
43.4f,
43.7f,
44.4f,
45.1f,
45.8f,
46.6f,
47f,
47.4f,
47.5f,
47.7f,
48.1f,
48.4f,
48.6f,
48.8f,
49f,
49.2f,
49.4f,
49.6f,
50f,
50.4f,
50.5f,
50.7f,
51.1f,
52.7f,
53f,
53.4f,
53.8f,
54.1f,
54.5f,
54.9f,
56.2f,
55.6f,
55.7f,
56.4f,
56.7f,
57.1f,
57.4f,
57.8f,
58.2f,
58.6f,
59f,
59.4f,
59.7f,
60.1f,
60.4f,
60.8f,
61.2f,
61.6f,
61.9f,
62.3f,
62.6f,
63f,
63.4f,
63.8f,
64.1f,
64.6f,
64.9f,
65.3f,
65.7f,
66.1f,
66.5f,
66.8f,
67.2f,
67.6f,
68f,
68.4f,
68.7f,
69.1f,
69.5f,
69.9f,
70.3f,
70.7f,
71f,
71.4f,
71.8f,
72.1f,
72.5f,
72.8f,
73.2f,
73.6f,
74f,
74.2f,
74.7f,
75.1f,
75.5f,
75.9f,
76.3f,
76.7f,
76.7f,
77.1f,
77.4f,
77.6f,
77.8f,
78.1f,
78.3f,
78.5f,
78.7f,
78.9f,
79.1f,
79.3f,
79.4f,
79.7f,
80f,
80.4f,
80.7f,
81.1f,
81.5f,
81.9f,
82.3f,
82.7f,
82.8f,
83f,
83.2f,
83.6f,
83.8f,
84f,
84.2f,
84.4f,
84.6f,
84.8f,
84.9f,
85.1f,
85.3f,
85.5f,
85.7f,
86.4f,
86.8f,
87.2f,
87.5f,
87.9f,
88.3f,
88.6f,
89f,
89.1f,
89.3f,
89.8f,
90.1f,
90.5f,
90.7f,
90.9f,
91.1f,
91.3f,
91.5f,
91.7f,
92.4f,
92.5f,
92.7f,
92.9f,
93.1f,

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
        if (timer >= 98)
        {
            SceneManager.LoadScene("ClearScene");
        }

    }
}
