using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleSpawner : MonoBehaviour
{
    ObjectPooler objectPooler;
    private void Start()
    {
        objectPooler = ObjectPooler.Instance; 
    }

    private void FixedUpdate()
    {
        objectPooler.SpawnFromPool("Marble", transform.position, Quaternion.identity);
    }
}
