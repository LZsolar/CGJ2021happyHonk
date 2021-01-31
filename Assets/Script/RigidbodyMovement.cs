using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    Rigidbody2D _rb;
    public Animator _animator;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 inputVector = new Vector3(x,y,0f).normalized;
        if(inputVector.magnitude <= 0f)
        {
            _animator.SetBool("isWalking",false);
        }
        else
        {
            _animator.SetBool("isWalking",true);
            _animator.SetFloat("Xpos",inputVector.x);
            _animator.SetFloat("Ypos",inputVector.y);
        }
        _rb.velocity =  inputVector * speed;
    }
}
