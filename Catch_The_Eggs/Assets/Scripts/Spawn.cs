using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawn : MonoBehaviour
{
    public float dimension = 1f;
    public GameObject Eg;
    public static float no1,no2;
    public Transform t;
    private Vector3 v;
    public static float score=0f;
    public static float count = 0f;
    public static float delay = 3f;
    // Start is called before the first frame update
    void Start()
    {
        v = t.position;
        spawn();
        //Instantiate(Egg, new Vector3(2f, 6f, 2f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (delay >= 1f)
        {
            //delay = 2f - (Time.timeSinceLevelLoad) / 20f;
        }
        //Debug.Log(delay);
        if (count == 10)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    void spawn()
    {
        no1 = (float)Random.Range(-73, 73)/10;
        no2 = (float)Random.Range(-73, 73) /10;
        Instantiate(Eg, v + new Vector3(no1, 12f, no2), Quaternion.identity);
        Invoke("spawn", delay);
    }
}
