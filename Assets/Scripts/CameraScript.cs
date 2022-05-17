using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Boolean moveBool = true;
    public Transform player;

    public float xCamera;
    public float yCamera;
    public float zCamera;
    
    
    
    void Update () {
        if (moveBool)
        {
            transform.position = player.transform.position + new Vector3(xCamera, yCamera, zCamera);
        }
        
      
    }

    public void move()
    {
        moveBool = false;
    }

   
}
