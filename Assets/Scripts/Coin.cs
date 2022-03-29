using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public float rotationSpeed = 60;
    public GameObject player;
    public GameObject coin;

    
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
            player.GetComponent<PlayerStats>().coins++;
            Destroy(coin);
        }
    }
}
