using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolymorphismInteractor : MonoBehaviour
{
    [SerializeField]
    private Interactable target;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && target != null)
        {
            target.Interact();
        }
    }
}
