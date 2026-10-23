using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointEnemy : MonoBehaviour
{
    public float speed = 4f;
    private int index = 0;

    private void Update()
    {
        Transform target = Waypoints.points[index];
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            index++;
            
            if(index >= Waypoints.points.Length)
            {
                // lose a life

                Destroy(gameObject);
            }
        }
    }
}
