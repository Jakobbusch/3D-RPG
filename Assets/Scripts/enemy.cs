using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    private Animator anim;
    private Rigidbody rb;
    private float dist;
    private Vector3 direction;
    [SerializeField]
    private float moveSpeed;

    public GameObject player;
    
    private readonly int distanceHash = Animator.StringToHash("DistanceToPlayer");
    
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       
        direction = transform.position - player.transform.position;
        dist = Vector3.Distance(player.transform.position, transform.position);
        
        anim.SetFloat(distanceHash, dist);
        
        
        
    }

    IEnumerator waitforDamageCoroutine()
    {
      
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(2);
        player.GetComponent<PlayerStats>().Health += -0.1f;
    }
    private void LateUpdate()
    {
        
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Base Layer.Walk"))
        {
            
            transform.LookAt(player.transform);
            rb.AddRelativeForce(Vector3.forward*1f*moveSpeed,ForceMode.Force);
           
        }

        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Base Layer.Attack"))
        {

            StartCoroutine(waitforDamageCoroutine());
        }
    }
}
