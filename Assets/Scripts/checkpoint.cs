using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{
    public GameObject player;

    private bool check = false;

    public float x;

    public float y;

    public float z;

    private Vector3 checkposition;
    // Start is called before the first frame update
    void Start()
    {
        player.GetComponent<Rigidbody>();
        checkposition = new Vector3(x, y, z);
    }

    // Update is called once per frame
    void Update()
    {
        Checkpoint();
    }

    public void Checkpoint()
    {
      
        if (player.GetComponent<Rigidbody>().position.y <= -5f)
        {
          
            player.GetComponent<Rigidbody>().transform.position = checkposition;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (player.transform.position == transform.position)
        {
            if(collision.gameObject.CompareTag("Player"))
            {
                check = true;
              

            }
            
           
        }
    }
    
    
}
