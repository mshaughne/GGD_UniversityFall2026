using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");

        Goblin enemy1 = new Goblin();
        enemy1.TakeDamage(10);
        enemy1.Attack();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
