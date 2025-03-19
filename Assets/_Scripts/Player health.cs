using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerhealth : MonoBehaviour
{
    public int health;
    public double timer;
    

    // Start is called before the first frame update
    void Start()
    {
        health = 20;
        Time.timeScale = 1.0f;
        
    }
    public void damage(int x)
    {
        health -= x;
        Debug.Log(health);
    }
    void Update()
    {
        timer += Time.deltaTime;
        if (health >= 0 && timer>= 300)
        {
            Buttons.LoadWinScreen();
        }
        if (health <= 0 )
        {
            Time.timeScale = 0.0f;
            Buttons.LoadLossScreen();


        }

    }
}
