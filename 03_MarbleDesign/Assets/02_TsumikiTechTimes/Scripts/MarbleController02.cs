using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleController02 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // タグにより色の判定
        if(this.tag == "RedMarble")
        {
            GetComponent<Renderer>().material.SetColor("_Color", new Color(1, 0.433f, 0.411f, 1));
        }else if(this.tag == "BlueMarble")
        {
            GetComponent<Renderer>().material.SetColor("_Color", new Color(0.227f, 0.855f, 1, 1));
        }else if (this.tag == "BlackMarble")
        {
            GetComponent<Renderer>().material.SetColor("_Color", new Color(0.605f, 0.590f, 0.622f, 1));
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
