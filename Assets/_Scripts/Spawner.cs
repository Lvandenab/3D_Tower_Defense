using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public double maxspawnnum;
    public double spawnpoints;
    public double smallprice;
    public double largeprice;
    public double spacing;
    public double waittime;
    public GameObject smallenemy;
    public GameObject largeenemy;
    // Start is called before the first frame update
    void Start()
    {
        smallprice = 1;
        largeprice = 6;
        maxspawnnum = 2;  
        spawnpoints = 1;
        spacing = 0;
        waittime = 10;

    }
    public void spawnsmall()
    {
        Transform spawner = GameObject.Find("Enemy spawn").transform;
        Vector3 pos = spawner.position;
        Instantiate(smallenemy, new Vector3(pos.x, pos.y, pos.z), spawner.rotation, null);
    }
    public void spawnbig()
    {
        Transform spawner = GameObject.Find("Enemy spawn").transform;
        Vector3 pos = spawner.position;
        Instantiate(largeenemy, new Vector3(pos.x,pos.y,pos.z), spawner.rotation, null);
    }
    // Update is called once per frame
    void Update()
    {
        if (spawnpoints < smallprice)
        {
            waittime = 10;
            maxspawnnum *= 1.5;
            spawnpoints = maxspawnnum;
            largeprice *= 1.25;
            smallprice *= 1.25;

        }
        if (waittime > 0)
        {
            waittime -= Time.deltaTime;
        }
        else if (waittime <= 0)
        {
            
            spacing += Time.deltaTime;
            if (spacing >= .4)
            {
                
                if (spawnpoints >= largeprice)
                {
                    spawnbig();
                    spawnpoints -= largeprice;
                    Debug.Log("largeenemy");
                }
                else if (spawnpoints >= smallprice)
                {
                    spawnsmall();
                    spawnpoints -= smallprice;
                    Debug.Log("smallenemy");
                }
                spacing = 0;
                

            }
            /*spawnnum += Time.deltaTime;
            if (spawnnum%3 < .01)
            {
                Transform spawner = GameObject.Find("Enemy spawn").transform;
                Instantiate(enemy, spawner.position, spawner.rotation, null);
            }*/
        }


    }
}
