using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build_A_Baddie : MonoBehaviour
{
    //Put your own functions here!
    public BadGuyBrain badGuyBrain;

    private Rigidbody2D rigidBody; 

    public float knockback = 10f;

    private void Start()
    {
        badGuyBrain = GetComponent<BadGuyBrain>();
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            rigidBody.position = new Vector2(rigidBody.position.x, rigidBody.position.y + knockback);
            
    }
}
