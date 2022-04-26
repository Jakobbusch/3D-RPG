using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openChest : MonoBehaviour
{
    [SerializeField]
    private GameObject openChestText;
    [SerializeField]
    private GameObject player;

    private bool indistance = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (indistance && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Animate stuff");
            player.GetComponent<PlayerMovement>().transport();
            
        }

    }
    
    private void OnTriggerEnter(Collider other)
    {
        
        openChestText.SetActive(true);
        indistance = true;

    }
    
    private void OnTriggerExit(Collider other)
    {
        openChestText.SetActive(false);
        indistance = false;
    }
}
