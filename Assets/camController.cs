using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camController : MonoBehaviour
{
    public GameObject character;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        gameObject.transform.parent = character.transform;
    }
}
