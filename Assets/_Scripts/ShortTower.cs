using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShortTower : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Turret;
    public GameObject Target;
    public float Range = 5.0f;

    //fire
    public float firerate = 3f;
    private float firecooldown = 0f;
    public GameObject Longbullet;
    public Transform firespot;
    public Animator animator;



    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        firecooldown -= Time.deltaTime;
        GameObject[] possibleTargets = GameObject.FindGameObjectsWithTag("Enemy");

        if (possibleTargets.Length == 0) return;

        Target = possibleTargets[0];

        foreach (GameObject o in possibleTargets)
        {
            if (Vector3.Distance(transform.position, o.transform.position) <
                Vector3.Distance(transform.position, Target.transform.position))
            {
                Target = o;
            }
        }
        Turret.transform.LookAt(Target.transform.position);
        if (Vector3.Distance(transform.position, Target.transform.position) <= Range)
        {
            if (firecooldown <= 0f)
            {
                shoot();
                firecooldown = 1f / firerate;
            }
        }
        firecooldown -= Time.deltaTime;


    }
    void shoot()
    {
        GameObject bulletGo = (GameObject)Instantiate(Longbullet, firespot.position, firespot.rotation);
        LongBullet longbullet = bulletGo.GetComponent<LongBullet>();
        animator.Play("Shoot");
        if (longbullet != null)
            longbullet.Seek(Target);
        Debug.Log("shoot");

    }
}
