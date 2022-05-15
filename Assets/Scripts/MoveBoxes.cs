using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBoxes : MonoBehaviour
{
    public Transform box;
    public Transform player;

    private Rigidbody m_Rigidbody;
    public float firstX;
    public float firsty;
    public float firstz;
    
    public float secondX;
    public float secondy;
    public float secondz;
    public float speed;

    private Vector3 back;
    private Vector3 forth;
    
    float phase = 0;
    float phaseDirection = 1;
    private Vector3 secondPosition;
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }





    // Update is called once per frame
    void Update()
    {

        back = new Vector3(firstX, firsty, firstz);
        forth = new Vector3(secondX, secondy, secondz);
        
        m_Rigidbody.MovePosition(Vector3.Lerp(back, forth, phase));   //phase determines (in percent, basically) where on the line between the points "back" and "forth" you want the enemy to be placed, so if we gradually increase/decrease the variable, it makes the enemy move between those two points.
        phase += Time.deltaTime * speed * phaseDirection; //subtracts from 1 to zero when phaseDirection is negative, adds from zero to one when phaseDirection is positive.
        if(phase >= 1 || phase <= 0) phaseDirection *= -1; //flip the sign to flip direction
    }
}
