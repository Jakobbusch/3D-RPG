using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingCylender : MonoBehaviour
{

    Rigidbody m_Rigidbody;
    Vector3 m_EulerAngleVelocity;
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();

        m_EulerAngleVelocity = new Vector3(0, 15, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity * Time.fixedDeltaTime);
        m_Rigidbody.MoveRotation(m_Rigidbody.rotation * deltaRotation);
    }


}
