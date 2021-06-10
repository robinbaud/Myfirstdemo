using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ennemi : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 5f;
    
    void FixedUpdate()
    {
        rb.AddForce(-speed * Time.deltaTime, 0, 0);
    }
}
