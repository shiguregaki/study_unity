using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickControllerByScript : MonoBehaviour
{
    Vector3 startPos, startMousePos;
    float springRate = 150f;

    Rigidbody rb;
    float forceRate = 5.0f;

    void Start()
    {
        startPos = transform.position;
        rb = this.GetComponent<Rigidbody>();
    }

    void Update()
    {
        // バネの力
        Vector3 stringForce = - springRate * (transform.position - this.startPos);
        rb.AddForce(stringForce);

        // スワイプの長さを求める
        if (Input.GetMouseButtonDown(0))
        {
            this.startMousePos = Input.mousePosition;
        }
        else if (Input.GetMouseButton(0))
        {
            Vector3 currentMousePos = Input.mousePosition;
            float force_y = this.forceRate * (currentMousePos.y - this.startMousePos.y);
            Vector3 force = new Vector3(0.0f, force_y, 0.0f);
            rb.AddForce(force);
        }
    }
}
