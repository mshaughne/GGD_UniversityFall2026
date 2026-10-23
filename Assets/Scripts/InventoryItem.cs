using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItem : MonoBehaviour
{
    public string itemName;
    public int weight;
    public int id;
    public float durability;
    public bool canBeDropped = true;
}
