using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    
    [SerializeField]
    private float rotationalSpeed;

    [SerializeField]
    private float moveSpeed;

    private float runfac = 1;
    private float vertical;
    private float horizontal;
    private bool jump;
    private Animator anim;
    private Rigidbody rb;

    //private bool run = Animator.StringToHash("Run");
    private readonly int speedHash = Animator.StringToHash("Speed");
    private readonly int jumpHash = Animator.StringToHash("Jump");
    
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");
        jump = Input.GetButtonDown("Jump");
        
        
        if (jump && !anim.GetCurrentAnimatorStateInfo(0).IsName("BaseLayer.Jump")) {
            anim.SetTrigger(jumpHash);
            rb.AddForce(new Vector3(0,5,0),ForceMode.Impulse);
            rb.AddForce(transform.forward*2,ForceMode.Impulse);
            
            
            
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = 8;
            anim.SetBool("Run",true);
            runfac = 2;

        }else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed = 3;
            anim.SetBool("Run",false);
            runfac = 1;
        }
        
        
    }

    private void FixedUpdate()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Base Layer.Jump"))
        {
            return;
        }
        anim.SetFloat(speedHash, vertical*runfac);
        rb.MovePosition(transform.position + vertical * moveSpeed * 0.01f * transform.forward);
        rb.MoveRotation(rb.rotation * Quaternion.Euler(new Vector3(0f, horizontal * rotationalSpeed, 0f)));
    }
}