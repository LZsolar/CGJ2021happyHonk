using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    Vector2 mm;

    public bool Fitem1;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Fitem1 = false;
    }

    // Update is called once per frame
    void Update()
    {
        mm.x = Input.GetAxis("Horizontal");

        mm.y = Input.GetAxis("Vertical");

        rb.MovePosition(rb.position + mm * speed * Time.deltaTime);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (Input.GetKeyDown(KeyCode.Z) && collision.gameObject.tag == "item1")
        {
            print("item 1 got");
            Destroy(collision.gameObject);
            Fitem1 = true;
        }

    }

}
