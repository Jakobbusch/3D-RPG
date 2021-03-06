using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrel : MonoBehaviour
{
    [SerializeField]
    private AudioClip[] audioClips;

    private Rigidbody rb;
    
    private AudioSource audioSource;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

   
    void Update()
    {
        if (rb.velocity.x > 0 | rb.velocity.y > 0 | rb.velocity.z > 0)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.PlayOneShot(audioClips[0]);
            }
           
        }
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Player"))
        {
            audioSource.PlayOneShot(audioClips[1]);
            
        }

        if (other.collider.CompareTag("ground"))
        {
            audioSource.PlayOneShot(audioClips[2]);
        }
    }
}
