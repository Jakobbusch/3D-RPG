using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockPlayer : MonoBehaviour
{
    
    [SerializeField]
    private float moveSpeed;
    
    [SerializeField]
    private float jumpHeight;

    private Vector3 startPos;
    private Boolean rotated;
    
    private Animator anim;
    private Rigidbody rb;
    private float horizontal;
    private bool isgrounded = true;
    private bool jump;
    private readonly int speedHash = Animator.StringToHash("Speed");
    private readonly int jumpHash = Animator.StringToHash("Jump");
    // Start is called before the first frame update
    void Awake()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        startPos = transform.position;
        rotated = false;
    }

    // Update is called once per frame
    void Update()
    {
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
    
    
    IEnumerator ExampleCoroutine()
    {
        
        Vector3 m_NewForce = new Vector3(0, jumpHeight, 0);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(0.3f);
        rb.AddForce(m_NewForce,ForceMode.Impulse);
        
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("ground"))
        {
            isgrounded = true; 
        }

        if (collision.gameObject.CompareTag("barrel"))
        {
            transform.position = startPos;
            isgrounded = true;
        }else if (collision.gameObject.CompareTag("Respawn"))
        {
            transform.position = startPos;
            isgrounded = true;
        }
        
    }

    private void OnCollisionExit(Collision other)
    {
        if(other.gameObject.CompareTag("ground"))
        {
            isgrounded = false;
        }
    }
    
    
    private void FixedUpdate() {
        anim.SetFloat(speedHash, horizontal);

        var trans = transform;
        if (horizontal <= 0)
        {
            trans.rotation = new Quaternion(0, 0, 0, 1);
            rotated = true;

        }
        else
        {
            rotated = false;
            trans.rotation = new Quaternion(0, 90, 0, 1);
        }

        if (rotated)
        {
            rb.MovePosition(trans.position + (-horizontal) * moveSpeed * 0.01f * trans.forward);
        }
        else
        {
            rb.MovePosition(trans.position + horizontal * moveSpeed * 0.01f * trans.forward);
            //rb.MoveRotation(rb.rotation * Quaternion.Euler(new Vector3(0f, horizontal * rotationalSpeed, 0f)));
        }
        
        
            
    }
}
