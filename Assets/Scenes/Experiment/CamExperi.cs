using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamExperi : MonoBehaviour
{
    private Vector3 positionForCamera;
    public GameObject player;
 
    private Vector3 offset;
    public float of;
    public Vector3 setup = Vector3.up;
    private Boolean moveBool = true;
     
    public float offsetDistance = 2f;
 
    public float rotateSpeed = 3.0F;
    void Start()
    {
        offset = transform.position - player.transform.position;
    }
 
    void Update()
    {
        if (moveBool)
        {
            positionForCamera = player.transform.position - player.transform.forward * offsetDistance +setup ;
        }
        
       
    }
    void LateUpdate ()
    {
        if (moveBool)
        {
            //set camera position
            transform.position = positionForCamera;
            //set camera rotation
            transform.rotation = Quaternion.LookRotation(player.transform.position - transform.position, Vector3.up);
            // transform.position = player.transform.position + offset;
            // transform.Rotate(0, Input.GetAxis("Horizontal"), 0); 
        }
        
 
    }
    
    public void move()
    {
        moveBool = false;
    }
}

