using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongTower : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Turret;
    public GameObject Target;
    public float Range = 4.0f;

    //fire
    public float firerate = 1f;
    private float firecooldown = 0f;
    public GameObject Longbullet;
    public Transform firespot;
    public Animator animator;

    public Transform turner, looktarget;



    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] possibleTargets = GameObject.FindGameObjectsWithTag("Enemy");
        
        if (possibleTargets.Length == 0) return;

        Target = possibleTargets[0];
        looktarget = Target.transform;

        foreach (GameObject o in possibleTargets)
        {
            if (Vector3.Distance(transform.position, o.transform.position) <
                Vector3.Distance(transform.position, Target.transform.position))
            {
                Target = o;
            }
        }
        turner.LookAt(looktarget);
        //Physics.SyncTransforms();
        
        if (Vector3.Distance(transform.position, Target.transform.position) <= Range)
        {
            if( firecooldown <= 0f)
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
        
    }
}
