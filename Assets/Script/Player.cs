using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    Vector2 mm;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        mm.x = Input.GetAxis("Horizontal");

        mm.y = Input.GetAxis("Vertical");

        rb.MovePosition(rb.position + mm * speed * Time.deltaTime);
    }
}
