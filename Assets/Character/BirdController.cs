using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public int FlyForceUp = 300;
    public int FlyForceRight = 150;

    public bool BirdIsDead = false;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

  
    void FixedUpdate()
    {
        if(Input.GetMouseButton(0) && !BirdIsDead)
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector3.up * FlyForceUp);
        }
        if (Input.GetMouseButton(1) && !BirdIsDead)
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector3.right * FlyForceRight);
        }

    }
    
}
