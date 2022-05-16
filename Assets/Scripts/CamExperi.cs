using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamExperi : MonoBehaviour
{
    private Vector3 positionForCamera;
    public GameObject player;
    public Vector3 setup = Vector3.up;
    private Boolean moveBool = true;
     
    public float offsetDistance = 2f;
    
    void Start()
    {
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
        }
        
 
    }
    
    public void move()
    {
        moveBool = false;
    }
}

