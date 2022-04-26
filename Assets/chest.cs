using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;



public class chest : MonoBehaviour
{
    public GameObject maincam;
    public GameObject chestcam;
    [SerializeField]
    private GameObject openChest;
    public GameObject player;
    [SerializeField]
    private GameObject chestText;
    private bool indistance = false;
    private GameObject chestCamera;
    
    // Start is called before the first frame update
    void Start()
    {
        //maincam.enabled = true;
        //chestcam.enabled = false;
        //chestCamera = chestcam.GetComponent<GameObject>();
        chestcam.SetActive(false);
        


    }

    // Update is called once per frame
    void Update()
    {
        if (indistance && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Open chest");
            
            //maincam.enabled = false;
            //chestcam.enabled = true;
            maincam.SetActive(false);
            chestcam.SetActive(true);
            gameObject.SetActive(false);
            openChest.SetActive(true);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
        chestText.SetActive(true);
        indistance = true;

    }

    private void OnTriggerExit(Collider other)
    {
        chestText.SetActive(false);
        indistance = false;
    }
}
