using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemData : MonoBehaviour
{
    public bool interactible = true;
    public SpriteRenderer _renderer;
    public Item itemInfo;

    void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();
        _renderer.sprite = itemInfo.sprite;
    }
}
