using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marble : MonoBehaviour, IPooledObject
{
    public int i;
    public float timer = 10;
    public float deger = 10;
   public void OnObjectSpawn()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            i = Random.Range(0, 4);
            timer = deger;
            if (i == 0)
                transform.position += Vector3.right * Time.deltaTime;
            if (i == 1)
                transform.position += Vector3.left * Time.deltaTime;
            if (i == 2)
                transform.position += Vector3.up * Time.deltaTime;
            if (i == 3)
                transform.position += Vector3.down * Time.deltaTime;
        }

    }
    

    
}
