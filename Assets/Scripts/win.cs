using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class win : MonoBehaviour
{
    [SerializeField]
    private GameObject text;

    [SerializeField]
    private GameObject particle;
    
    [SerializeField]
    private GameObject canvas;

    
    private AudioSource source;

    [SerializeField]
    private AudioClip clip;

    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            source.PlayOneShot(clip);
            particle.SetActive(true);
            canvas.SetActive(true);
            
        }
    }

    private void OnCollisionStay(Collision collisionInfo)
    {
        text.SetActive(true);
        
    }

    private void OnCollisionExit(Collision other)
    {
        text.SetActive(false);
    }
}
