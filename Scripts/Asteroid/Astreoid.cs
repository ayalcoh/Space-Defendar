using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Astreoid : MonoBehaviour
{
    public float getForce = 10f;
    public float getTorque = 10f;
    Rigidbody rb;

    private void Awake() 
    {
        float randSize = Random.Range(0.9f, 3.1f);
        transform.localScale = Vector3.one *randSize; 

        
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        rb.AddForce(Vector3.forward * getForce);
        rb.AddTorque(Vector3.forward * getTorque);      
    }
}
