using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour
{
    public float a = 0f, b = 50f, t = 0.5f;

    public float timeElapsed, timeDuration = 3f;

    // Start is called before the first frame update
    void Start()
    {
        //float lerpValue = Mathf.Lerp(a, b, t);
        //Debug.Log(lerpValue);
    }

    // Update is called once per frame
    void Update()
    {
        if (timeElapsed < timeDuration)
        {
            float value = Mathf.Lerp(a, b, timeElapsed / timeDuration);
            Debug.Log(value);

            transform.position = new Vector3(0, value, 0);

            timeElapsed += Time.deltaTime;
            //timeElapsed = timeElapsed + Time.deltaTime;
        }
    }
}
