using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockerCoin : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed = 60;
    [SerializeField]
    private GameObject maincam;
    [SerializeField]
    private GameObject chestcam;

    [SerializeField] private GameObject player;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }


    void Update()
    {
        transform.Rotate(0,rotationSpeed * Time.deltaTime,0,Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            player.SetActive(true);
            chestcam.SetActive(false);
            maincam.SetActive(true);
        }
    }
}
