using Unity.VisualScripting;
using UnityEngine;

public class LongBullet : MonoBehaviour
{
    public float speed = 50f;

    private GameObject target;
    public void Seek(GameObject _target)
    {
        target = _target;
    }
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }
        Vector3 dir = target.transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        /*if (dir.magnitude <= distanceThisFrame)
        {
            //HitTarget();
            return;
        }*/
        transform.position = Vector3.MoveTowards(transform.position, dir, distanceThisFrame);
        

    }
}
