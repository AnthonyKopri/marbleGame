using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMovement : MonoBehaviour
{
    public float speed = 2f;
    public float gravForce = 5f;
    public bool gravSwitch = false;

    void Update()
    {
        transform.position += Vector3.right * Time.deltaTime * speed;
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
