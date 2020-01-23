using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class c1 : MonoBehaviour
{
    public float xd = 1920;
    public float yd = 1080;
    public Transform t;
    public Transform curs;
    public float time1 = 0f;
    public float time2 = 0f;
    public Text te1;
    public Text te2;
    // Start is called before the first frame update
    void Start()
    {
        time1 = 0f;
        time2 = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        te1.text = curs.position.x.ToString("0");
        te2.text = curs.position.y.ToString("0");
        curs.position = new Vector3(400 - xd * (t.position.x - 400) / 2, 240 + yd * (t.position.y - 240), 0f);
        Debug.Log(curs.position.x);
        Debug.Log(curs.position.y);
        if (curs.position.y> 160f && curs.position.y < 280f && curs.position.x > 580f && curs.position.x < 1200f)
        {
            Debug.Log("GSHDF");
            time1 += Time.deltaTime;
        }
        if (curs.position.y > 1900f && curs.position.y < 2500f && curs.position.x > 580f && curs.position.x < 1200f)
        {
            time2 += Time.deltaTime;
        }
        if (time1 > 1f)
        {
            Spawn.score = 0f;
            Spawn.count = 0f;
            Spawn.delay = 3f;
            SceneManager.LoadScene(1);
        }
        if (time2 > 2f)
        {
            //Debug.Log("GameOver");
            Application.Quit();
        }

    }

}
