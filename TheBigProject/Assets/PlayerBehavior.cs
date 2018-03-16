﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour {
    public float speed;
    private Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed*Time.deltaTime);
    }
    // Update is called once per frame
    void Update () {
		
	}
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.name == "Door")
        {
            Debug.Log("Hit");
        }
    }
}
