using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickController : MonoBehaviour
{
    Vector3 startPos, previousPos;
    Rigidbody rb;
    float forceRate = 10.0f;
    SpringJoint springJoint;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        springJoint = GetComponent<SpringJoint>();
    }

    // Update is called once per frame
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
            rb.AddForce(force);
            //rb.AddForce(force - springJoint.currentForce);
        }
    }
}
