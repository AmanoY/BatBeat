using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


//It's my life Easy譜面
public class NotesGenerator : MonoBehaviour
{
    float timer = 0.0f;

    int timeCount = 0;

    //Notesを発生させる時間
    public float[] timingEasy =
    {
4.6f,
6.9f,
9.3f,
11.7f,
14.2f,
14.6f,
15f,
16.5f,
17f,
17.4f,
18.9f,
19.4f,
19.8f,
21.3f,
21.8f,
22.2f,
23.7f,
24.2f,
24.6f,
26.1f,
26.6f,
27.3f,
27.8f,
28.5f,
29f,
29.4f,
30.9f,
31.4f,
31.8f,
33.3f,
33.8f,
34.2f,
35.7f,
36.2f,
36.6f,
38.1f,
38.6f,
39f,
40.5f,
41f,
41.7f,
42.2f,
42.6f,
43f,
43.4f,
43.8f,
45.3f,
45.8f,
46.2f,
47.7f,
48.2f,
48.6f,
48.9f,
49.4f,
49.8f,
50.1f,
53.7f,
54.3f,
55f,
55.6f,
56.2f,
56.8f,
57.3f,
57.9f,
58.5f,
-1.9f,
59.1f,
60.9f,
61.5f,
62.1f,
62.7f,
63.3f,
63.9f,
64.5f,
65.1f,
65.7f,
66.3f,
66.9f,
67.5f,
68.2f,
68.7f,
69.3f,
69.9f,
70.5f,
71.1f,
71.7f,
72.3f,
72.9f,
75.3f,
77.7f,
80.1f,
82.5f,





    };
    public GameObject notesPrefab;
    // NotesControl1 Notes;


    // Update is called once per frame
    void Update()
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
        if (timer >= 90)
        {
            SceneManager.LoadScene("ClearScene");
        }
    }

}
