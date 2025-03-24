using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRemover : MonoBehaviour
{
    public Playerhealth playerhealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        playerhealth.damage(1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
