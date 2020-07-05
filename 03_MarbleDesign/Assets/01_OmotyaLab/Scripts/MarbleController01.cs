using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleController01 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // タグにより色の判定
        if(this.tag == "RedMarble")
        {
            GetComponent<Renderer>().material.SetColor("_BaseColor", Color.red);
        }else if(this.tag == "BlueMarble")
        {
            GetComponent<Renderer>().material.SetColor("_BaseColor", Color.blue);
        }else if (this.tag == "BlackMarble")
        {
            GetComponent<Renderer>().material.SetColor("_BaseColor", Color.black);
        }

        Rigidbody rb = this.GetComponent<Rigidbody>();
        Vector3 force = new Vector3(0.0f, 0.0f, -500.0f);
        rb.AddForce(force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
