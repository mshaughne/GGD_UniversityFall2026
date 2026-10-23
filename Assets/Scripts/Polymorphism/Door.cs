using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : Interactable
{
    private bool isOpen = false;

    public override void Interact()
    {
        isOpen = !isOpen;

        if (isOpen)
        {
            Debug.Log("The door opens.");
        }
        else
        {
            Debug.Log("The door closes.");
        }
    }
}
