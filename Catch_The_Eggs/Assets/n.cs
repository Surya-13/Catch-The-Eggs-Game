using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class n : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Click1()
    {
        Spawn.score = 0f;
        Spawn.count = 0f;
        Spawn.delay = 3f;
        SceneManager.LoadScene(1);
    }
    public void Clicl2()
    {
        Application.Quit();
    }
}
