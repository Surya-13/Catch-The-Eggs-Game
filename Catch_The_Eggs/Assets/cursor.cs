using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class cursor : MonoBehaviour
{
    public float xd = 1920f;
    public float yd = 1080f;
    public Transform t;
    public Transform curs;
    public float time1 = 0f;
    public float time2 = 0f;
    //public Text te1;
    //public Text te2;
    // Start is called before the first frame update
    void Start()
    {
        time1 = 0f;
        time2 = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        //te1.text = curs.position.x.ToString("0");
        //te2.text = curs.position.y.ToString("0");
        curs.position = new Vector3(400-xd * (t.position.x-400) / 2,240 + yd * (t.position.y-240), 0f);
        //Debug.Log(curs.position.x);
        //Debug.Log(curs.position.y);
        if(curs.position.x>80f && curs.position.x<590f && curs.position.y>90f && curs.position.y < 190f )
        {
            time1 += Time.deltaTime;
        }
        if (curs.position.x > 750f && curs.position.x < 1260f && curs.position.y > 90f && curs.position.y < 190f)
        {
            time2 += Time.deltaTime;
        }
        if (time1 > 1f)
        {
            SceneManager.LoadScene(1);
        }
        if (time2 > 2f)
        {
            //Debug.Log("GameOver");
            Application.Quit();
        }

    }

}
