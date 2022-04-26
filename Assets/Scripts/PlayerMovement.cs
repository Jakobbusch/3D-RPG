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
    private Vector3 initGoal = new Vector3(0.719299972f, 1.84130001f, 0.358099997f);
    private Vector3 goal = new Vector3(0.713199973f, 1.61549997f, 0.353799999f);
    private bool transporting = false;
    private bool initialTrans = false;
    
    [SerializeField]
    private GameObject camera;
    

    private readonly int speedHash = Animator.StringToHash("Speed");
    private readonly int jumpHash = Animator.StringToHash("Jump");

    private void Awake() {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update() {
        if (transporting)
        {
            var step =  0.5f * Time.deltaTime; //
            var schaleChange = new Vector3(-0.001f, -0.001f, -0.001f);
            Quaternion target = Quaternion.Euler(0,365,0);
            //transform.rotation = Quaternion.Slerp(transform.rotation,target,Time.deltaTime*100);
            transform.Rotate(0,200*Time.deltaTime,0);
            if (!initialTrans)
            {
                transform.position = Vector3.MoveTowards(transform.position, initGoal, step);
                if (transform.localScale.x >= 0.05)
                {
                    transform.localScale += schaleChange;
                }
                else
                {
                    initialTrans = true;
                }
                
            }
            else
            {
                
                
                transform.position = Vector3.MoveTowards(transform.position, goal, step);
                if (transform.localScale.x >= 0.01)
                {
                    transform.localScale += schaleChange;
                }
                
                //transform.Translate(Vector3.forward*Time.deltaTime);
            }
            
        }
        else
        {
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
        yield return new WaitForSeconds(0.3f);
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
            moveSpeed = 2;
        }
        var trans = transform;
        rb.MovePosition(trans.position + vertical * moveSpeed * 0.01f * trans.forward);
        rb.MoveRotation(rb.rotation * Quaternion.Euler(new Vector3(0f, horizontal * rotationalSpeed, 0f)));
        
            
    }

    public void transport()
    {   
        camera.GetComponent<CamExperi>().move();
        transporting = true;
        Debug.Log("Transportation");
        gameObject.GetComponent<Rigidbody>().isKinematic = true;


    }


}
