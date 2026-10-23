using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    //int[] ints = { 4, 8, 2, 5 };

    [SerializeField]
    GameObject[] objects;

    //public List<int> newvalues = new List<int> { 4, 8, 2, 5 };

    List<List<GameObject>> lists;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(ints[0]);

        

        for (int i = 0; i < objects.Length; i++)
        {
            Debug.Log("Disabling item " + i + " named " + objects[i].name);
            objects[i].SetActive(false);
        }
        /*foreach (var obj in objects)
        {
            Debug.Log("Item name is: " + obj.gameObject.name);
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
