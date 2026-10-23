using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastDemo : MonoBehaviour
{
    [SerializeField]
    LayerMask mask;

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        /*Debug.DrawRay(transform.position, transform.right * 100, Color.red);
        if (Physics.Raycast(transform.position, transform.right, out hit, Mathf.Infinity, mask))
        {
            Debug.Log("Raycast hit " + hit.collider.gameObject.name);
            //if(hit.collider.gameObject.CompareTag("Enemy"))
            //{
            //    hit.collider.gameObject.GetComponent<PolymorphismEnemy>().Attack();
            //}
        }
        else
        {
            Debug.Log("Raycast did not hit");
        }*/

        /*Ray ray = new Ray(transform.position, transform.right);

        Debug.DrawRay(transform.position, transform.right * 100, Color.yellow);
        if(Physics.SphereCast(ray, 3f, out hit, 100f, mask))
        {
            Debug.Log("Hit " + hit.collider.name);
        }*/

        Collider[] hitColliders = Physics.OverlapSphere(transform.position, 5f, mask);
        foreach(var collider in hitColliders)
        {
            Debug.Log(collider.gameObject.name);
        }

        Collider2D[] hit2DColliders = Physics2D.OverlapCircleAll(transform.position, 5f, mask);
        
    }
}
