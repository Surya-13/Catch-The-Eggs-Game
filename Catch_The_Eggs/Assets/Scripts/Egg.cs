using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Egg : MonoBehaviour
{
    public AudioSource a;
    public MeshRenderer m;
    public AudioSource b;
    public SphereCollider bb;
    public Renderer rend;
    public Color c;
    // Start is called before the first frame update
    void Start()
    {
        a.enabled = false;
        b.enabled = false;
        bb.enabled = true;
        c.r = ((Spawn.no2 + 73) / 146) * 183;
        c.g = ((Spawn.no2 + 73) / 146) * 53;
        c.b = ((Spawn.no2 + 73) / 146) * 53;
        rend.material.SetColor("B73535", c);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Ground")
        {
            //b.Play(0);
            a.enabled = true;
            Invoke("dest", 1f);
            m.enabled = false;
            //Destroy(gameObject);
            Spawn.count++;
        }
        if(collision.collider.tag == "Basket")
        {
            bb.enabled = false;
            //a.Play(0);
            b.enabled = true;
            Invoke("dest", 1f);
            m.enabled = false;
            //Destroy(gameObject);
            Spawn.score += 10f;
        }
    }

    void dest()
    {
        Destroy(gameObject);
    }
}
