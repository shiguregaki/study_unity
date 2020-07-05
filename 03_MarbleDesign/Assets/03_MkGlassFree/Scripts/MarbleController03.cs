using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleController03 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();
        Vector3 force = new Vector3(0.0f, 0.0f, -500.0f);
        rb.AddForce(force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
