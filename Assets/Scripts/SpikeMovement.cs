using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeMovement : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * 9;   
    }
}
