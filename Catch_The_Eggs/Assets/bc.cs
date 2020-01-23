using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class bc : MonoBehaviour
{
    //public Transform obj;
    //public Text t1;
    //public Text t2;
    public Text t;
    // Start is called before the first frame update
    void Start()
    {
        t.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        t.text = Spawn.score.ToString("0");
        //t1.text = ((float)obj.position.x*100).ToString("0");
        //t2.text = ((float)obj.position.z * 100).ToString("0");
        //Debug.Log(obj.position.x);
        //Debug.Log(obj.position.z);
    }
}
