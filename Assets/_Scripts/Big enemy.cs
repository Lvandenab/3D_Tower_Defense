using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bigenemy : MonoBehaviour
{
    // Start is called before the first frame update
    public Path MyPath;
    public int currentDestination;
    public float Speed = 1.25f;
    public float WaypointAcceptableError = 0.01f;

    public Spawner spawner;
    public int health = 3;
    
    // Start is called before the first frame update
    void Start()
    {
        currentDestination = 0;
        MyPath = GameObject.Find("Waypoints").GetComponent<Path>();
        spawner= GameObject.Find("Enemy spawn").GetComponent<Spawner>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (currentDestination >= MyPath.Waypoints.Length) return;

        transform.position = Vector3.MoveTowards(transform.position, MyPath.Waypoints[currentDestination].position, Speed * Time.deltaTime);
        transform.LookAt(MyPath.Waypoints[currentDestination].position);

        if (Vector3.Distance(transform.position, MyPath.Waypoints[currentDestination].position) <= WaypointAcceptableError)
        {
            currentDestination++;
        }

    }
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(other.gameObject);
            health--;
        }
        if (health <= 0)
        {
            Destroy(gameObject);
            spawner.spawnsmall();
            spawner.spawnsmall();
            spawner.spawnsmall();
        }
    }
}
