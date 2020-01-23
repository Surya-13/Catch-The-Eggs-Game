using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    public float xdiff;
    public float zdiff;
    public float xl;
    public float zl;
    public float zd = 8.7f;
    public float xd = 8.7f;
    public Transform t;
    public Transform tt;
    private Vector3 v;
    // Start is called before the first frame update
    void Start()
    {
        v = tt.position;
    }

    // Update is called once per frame
    void Update()
    {
        float xx = t.position.x;
        float zz = t.position.z;
        //Debug.Log(xx);
        tt.position = v + new Vector3(xd - (((xx - xl) / xdiff) * xd),0f,zd - (((zz - zl) / zdiff) * zd));
        tt.position = new Vector3(Mathf.Clamp(tt.position.x,-7f,7f), tt.position.y, Mathf.Clamp(tt.position.z,14f,28f));
    }
}
