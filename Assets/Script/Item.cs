using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Item")]
public class Item : ScriptableObject
{
    public string objectName;
    public string objectLongName;
    public Sprite sprite;
    public itemType type;
    public string roomLocation;
}

public enum itemType
{
    Pickable,
    Combined
}