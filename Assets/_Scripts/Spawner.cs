using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    float spawnnum;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        spawnnum = 0;  
    }

    // Update is called once per frame
    void Update()
    {
        spawnnum += Time.deltaTime;
        if (spawnnum%3 < .01)
        {
            Transform spawner = GameObject.Find("Enemy spawn").transform;
            Instantiate(enemy, spawner.position, spawner.rotation, null);
        }
    }
}
