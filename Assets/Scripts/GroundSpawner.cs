using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    ObjectPooler objectPooler;
    public List<string> tags = new List<string>();
    int rand;
    int counter = 20;
    public bool flipped;
    public float timer = 2f;
    public float deger;

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
        timer -= Time.deltaTime;

        if(timer <= 0)
        {
            rand = Random.Range(0, 10);
            int rand2 = Random.Range(0, 10);
            int mirror = Random.Range(0, 2);

            if (mirror == 0)
            {
                objectPooler.SpawnFromPoolBottom(tags[rand], transform.position + new Vector3(objectPooler.poolOrderBottom[objectPooler.poolOrderBottom.Count-1].transform.position.x + 20f, 0, 0), Quaternion.Euler(-90, -90, 0));
                objectPooler.SpawnFromPoolTop(tags[rand2], transform.position + new Vector3(objectPooler.poolOrderTop[objectPooler.poolOrderTop.Count-1].transform.position.x + 20f, 10, 0), Quaternion.Euler(-270, -90, 0));
            }
            else
            {
                objectPooler.SpawnFromPoolBottom(tags[rand], transform.position + new Vector3(objectPooler.poolOrderBottom[objectPooler.poolOrderBottom.Count-1].transform.position.x + 20f, 0, 0), Quaternion.Euler(-90, 90, 0));
                objectPooler.SpawnFromPoolTop(tags[rand2], transform.position + new Vector3(objectPooler.poolOrderTop[objectPooler.poolOrderTop.Count-1].transform.position.x + 20f, 10, 0), Quaternion.Euler(-270, 90, 0));

            }
            counter += 20;

            timer = deger;
        }

        
    }
}
