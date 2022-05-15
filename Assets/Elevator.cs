using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    [SerializeField]
    private GameObject cylinder;
    
    private float maxHeight = 0.594f;

    private float minHeight = 0.026f;
    private bool up = false;
    private bool down = true;

    private float rotationGoal = 0.69f;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (cylinder.transform.rotation.y >=rotationGoal)
        {
            
            if (down)
            {
                up = false;
                if (transform.position.y > minHeight)
                {
                    transform.Translate(Vector3.down*0.1f*Time.deltaTime);
                    
                }
                else
                {
                    down = false;
                    up = true;
                }
                
            }
            else if (up)
            {
                if (transform.position.y < maxHeight)
                {
                    transform.Translate(Vector3.up*0.1f*Time.deltaTime);
                    
                }
                else
                {
                    up = false;
                    down = true;
                }
            }
            
            
        }
    }
}
