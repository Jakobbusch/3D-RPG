using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform player;

    public float xCamera;
    public float yCamera;
    public float zCamera;
    
    
    // Update is called once per frame
    void Update () {
        transform.position = player.transform.position + new Vector3(xCamera, yCamera, zCamera);
    }
}
