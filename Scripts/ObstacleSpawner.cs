using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public float maxTime = 1;
    public float timer = 0;
    public GameObject Obstacle;
    public float height;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
           GameObject newObstacle =  Instantiate(Obstacle);
            newObstacle.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newObstacle, 25);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
