using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockerCoin : MonoBehaviour
{
    public float rotationSpeed = 60;
    public GameObject maincam;
    public GameObject chestcam;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,rotationSpeed * Time.deltaTime,0,Space.World);
        
        
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            // win wuhu do some effect and go back to game
            gameObject.SetActive(false);
            chestcam.SetActive(false);
            maincam.SetActive(true);



        }
    }
}
