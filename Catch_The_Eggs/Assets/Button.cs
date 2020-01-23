using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


    }
    public void Click1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Click2()
    {
        Application.Quit();
    }
    public void Click3()
    {
        Spawn.score = 0f;
        Spawn.count = 0f;
        Spawn.delay = 3f;
        SceneManager.LoadScene(0);
    }
}
