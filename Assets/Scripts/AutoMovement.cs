using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMovement : MonoBehaviour
{
    public float speed = 10f;
    public float gravForce = 5f;
    public bool gravSwitch = false;
    public Rigidbody rb;
    private void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //if(rb.velocity.x < 0f)
        //{
        //    rb.velocity = new Vector3(rb.velocity.x * -1, rb.velocity.y, rb.velocity.z);
        //}
        //rb.velocity = speed * rb.velocity.normalized;
        if (Input.GetMouseButtonDown(0))
        {
            gravSwitch = !gravSwitch;
        }
        if (gravSwitch)
        {
            Physics.gravity = new Vector3(0, gravForce, 0);
        }
        else
        {
            Physics.gravity = new Vector3(0, -gravForce, 0);
        }
    }

}
