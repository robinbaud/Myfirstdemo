using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public Transform[] spawnpoint;
    public GameObject block; 
    private float timer = 1;
    private float interval = 4;
    
    void Update()
    {
        if(Time.time >= timer)
        {
            Spawn();
            timer = Time.time + interval;
        } 
    }

    void Spawn() 
    {
        int randomindex = Random.Range(0, spawnpoint.Length);
        for (int i = 0; i < spawnpoint.Length; i++)
        {
           if(randomindex != i)
            {
                Instantiate(block, spawnpoint[i].position, Quaternion.identity);
            }
        }
    }
}
