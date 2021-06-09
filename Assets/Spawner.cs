using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstacles;
    private float timeBtwSpawn;
    public float startTimebtwSpawn,decreasetime,mintime=0.65f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeBtwSpawn<=0)
        { int rand = Random.Range(0, obstacles.Length);
            Instantiate(obstacles[rand], transform.position, Quaternion.identity);
            timeBtwSpawn = startTimebtwSpawn;
            if(startTimebtwSpawn>mintime)
            {
                startTimebtwSpawn -= decreasetime;
            }
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
       
    }
}
