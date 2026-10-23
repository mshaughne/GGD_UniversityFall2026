using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Interactable
{
    private bool isOpen = false;

    public override void Interact()
    {
        isOpen = !isOpen;

        if(isOpen)
        {
            Debug.Log("The chest opens.");
        }
        else
        {
            Debug.Log("The chest closes.");
        }
    }
}
