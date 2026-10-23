using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlerpRotate : MonoBehaviour
{
    public Transform target;

    [Range(0f, 1f)]
    public float ratio = 0f;

    // Update is called once per frame
    void Update()
    {
        if (target == null) return;

        transform.position = Vector3.Slerp(Vector3.zero,
            target.position, ratio);

        transform.rotation = Quaternion.Slerp(transform.rotation,
            target.rotation, ratio * Time.deltaTime);
    }
}
