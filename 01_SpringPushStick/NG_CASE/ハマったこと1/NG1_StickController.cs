using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickController : MonoBehaviour
{
    Vector3 startPos;
    Rigidbody rb;
    float forceRate = 1.0f;
    SpringJoint springJoint;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        springJoint = GetComponent<SpringJoint>();
    }

    void Update()
    {
        Debug.Log(springJoint.currentForce);

        // スワイプの長さを求める
        if (Input.GetMouseButtonDown(0))
        {
            this.startPos = Input.mousePosition;
        }
        else if(Input.GetMouseButton(0)){
            Vector3 currentPos = Input.mousePosition;
            float force_y = this.forceRate * (currentPos.y - this.startPos.y);
            Vector3 force = new Vector3(0.0f, force_y, 0.0f);
            rb.AddForce(force - springJoint.currentForce);
        }
    }
}
