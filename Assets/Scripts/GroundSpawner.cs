using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    ObjectPooler objectPooler;
    public List<string> tags = new List<string>();
    int rand;

    private void Start()
    {
        objectPooler = ObjectPooler.Instance;
        foreach (ObjectPooler.Pool pool in objectPooler.pools)
        {
            tags.Add(pool.tag);
        }

    }

    private void FixedUpdate()
    {
        rand = Random.Range(0, 10);
        objectPooler.SpawnFromPool(tags[rand], transform.position + transform.right * Random.Range(0,100), Quaternion.identity);
    }
}
