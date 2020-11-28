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
            int rand3 = Random.Range(10, 13);
            int mirror = Random.Range(0, 2);

            if (mirror == 0)
            {
                objectPooler.SpawnFromPoolBottom(tags[rand], transform.position + new Vector3(objectPooler.poolOrderBottom[objectPooler.poolOrderBottom.Count-1].transform.position.x + 20f, 0, 0), Quaternion.Euler(-90, -90, 0));
                objectPooler.SpawnFromPoolTop(tags[rand2], transform.position + new Vector3(objectPooler.poolOrderTop[objectPooler.poolOrderTop.Count-1].transform.position.x + 20f, 20, 0), Quaternion.Euler(-270, -90, 0));
                if (rand3 == 10)
                objectPooler.SpawnFromPoolObstacle(tags[rand3], transform.position + new Vector3(objectPooler.poolOrderBottom[objectPooler.poolOrderBottom.Count - 1].transform.position.x, objectPooler.poolOrderBottom[objectPooler.poolOrderBottom.Count - 1].transform.position.y + 4.5f, 0), Quaternion.Euler(270, 90, 0));
                if(rand3 == 11)                
                objectPooler.SpawnFromPoolObstacle(tags[rand3], transform.position + new Vector3(objectPooler.poolOrderBottom[objectPooler.poolOrderBottom.Count - 1].transform.position.x, objectPooler.poolOrderBottom[objectPooler.poolOrderBottom.Count - 1].transform.position.y + 4.5f, 0), Quaternion.Euler(0, 90, 0));
                if (rand3 == 12)
                objectPooler.SpawnFromPoolObstacle(tags[rand3], transform.position + new Vector3(objectPooler.poolOrderBottom[objectPooler.poolOrderBottom.Count - 1].transform.position.x, objectPooler.poolOrderBottom[objectPooler.poolOrderBottom.Count - 1].transform.position.y + 5.8f, 0), Quaternion.Euler(180, -90, 0));

            }
            else
            {
                objectPooler.SpawnFromPoolBottom(tags[rand], transform.position + new Vector3(objectPooler.poolOrderBottom[objectPooler.poolOrderBottom.Count-1].transform.position.x + 20f, 0, 0), Quaternion.Euler(-90, 90, 0));
                objectPooler.SpawnFromPoolTop(tags[rand2], transform.position + new Vector3(objectPooler.poolOrderTop[objectPooler.poolOrderTop.Count-1].transform.position.x + 20f, 20, 0), Quaternion.Euler(-270, 90, 0));
                if (rand3 == 10)
                objectPooler.SpawnFromPoolObstacle(tags[rand3], transform.position + new Vector3(objectPooler.poolOrderBottom[objectPooler.poolOrderBottom.Count - 1].transform.position.x, objectPooler.poolOrderBottom[objectPooler.poolOrderBottom.Count - 1].transform.position.y + 16f, 0), Quaternion.Euler(90, -90, 0));
                if (rand3 == 11)
                objectPooler.SpawnFromPoolObstacle(tags[rand3], transform.position + new Vector3(objectPooler.poolOrderBottom[objectPooler.poolOrderBottom.Count - 1].transform.position.x, objectPooler.poolOrderBottom[objectPooler.poolOrderBottom.Count - 1].transform.position.y + 16f, 0), Quaternion.Euler(180, -90, 0));if (rand3 == 11)
                if (rand3 == 12)
                objectPooler.SpawnFromPoolObstacle(tags[rand3], transform.position + new Vector3(objectPooler.poolOrderBottom[objectPooler.poolOrderBottom.Count - 1].transform.position.x, objectPooler.poolOrderBottom[objectPooler.poolOrderBottom.Count - 1].transform.position.y + 5.8f, 0), Quaternion.Euler(180, -90, 0));
            }

            //objectPooler.SpawnFromPoolBottom(tags[Random.Range(10,13)], transform.position + new Vector3(objectPooler.poolOrderBottom[objectPooler.poolOrderBottom.Count - 1].transform.position.x, objectPooler.poolOrderBottom[objectPooler.poolOrderBottom.Count - 1].transform.position.y + 3, 0), Quaternion.Euler(-90, 90, 0));

            counter += 20;

            timer = deger;
        }

        
    }
}
