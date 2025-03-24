using System.Collections;
using System.Collections.Generic;
using TMPro;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Playerhealth : MonoBehaviour
{
    public int health ;
    public TextMeshProUGUI healthText;

    public float timer = 300;
    public TextMeshProUGUI timeleft;

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
    private void updatenums()
    {
        healthText.text = "Health : " + health;
        timeleft.text = "Time Spent : " + timer;
    }
    void Update()
    {
        updatenums();
        timer -= Time.deltaTime;
        if (health >= 0 && timer<= 0)
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
