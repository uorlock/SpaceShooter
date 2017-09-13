using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerMover : MonoBehaviour
{
    public Rigidbody rb;

    public float speed;

	void Start ()
    {
        rb.velocity = transform.forward * speed;
		
	}
}
