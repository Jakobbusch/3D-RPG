using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    private bool Pushing = false;
[SerializeField]
    private GameObject cyl;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Pushing)
        {
            if (cyl.transform.rotation.y <= 0.7)
            {
                cyl.transform.Rotate(0,30*Time.deltaTime,0);
            }
        }
    }

    private void OnCollisionStay(Collision other)
    {
        if (other.collider.CompareTag("Player"))
        {
            Pushing = true;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.collider.CompareTag("Player"))
        {
            Pushing = false;
        }
    }
}
