using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float rotationalSpeed;

    [SerializeField]
    private float moveSpeed;

    [SerializeField]
    private float jumpHeight;

    private bool isgrounded = true;
    private float vertical;
    private float horizontal;
    private bool jump;
    private Animator anim;
    private Rigidbody rb;
    private bool grounded;

    private readonly int speedHash = Animator.StringToHash("Speed");
    private readonly int jumpHash = Animator.StringToHash("Jump");

    private void Awake() {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update() {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");
        jump = Input.GetButtonDown("Jump");

        if (isgrounded == true)
        {
            if (jump && !anim.GetCurrentAnimatorStateInfo(0).IsName("BaseLayer.Jump")) {
                anim.SetTrigger(jumpHash);
            
                StartCoroutine(ExampleCoroutine());
            }
        }
      
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("ground"))
        {
            Debug.Log("on ground");
            isgrounded = true; 
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if(other.gameObject.CompareTag("ground"))
        {
            Debug.Log("off ground");
            isgrounded = false;
        }
    }

    IEnumerator ExampleCoroutine()
    {
        
        Vector3 m_NewForce = new Vector3(0, jumpHeight, 0);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(0.4f);
        rb.AddForce(m_NewForce,ForceMode.Impulse);
        
    }

    private void FixedUpdate() {
        anim.SetFloat(speedHash, vertical);

        if (vertical < -0.2)
        {
            moveSpeed = 1;
        }
        else
        {
            moveSpeed = 8;
        }
        var trans = transform;
        rb.MovePosition(trans.position + vertical * moveSpeed * 0.01f * trans.forward);
        rb.MoveRotation(rb.rotation * Quaternion.Euler(new Vector3(0f, horizontal * rotationalSpeed, 0f)));
        
            
    }
}
