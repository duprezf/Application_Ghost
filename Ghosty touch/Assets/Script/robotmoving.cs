using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robotmoving : MonoBehaviour {

    public float speed;
    Rigidbody2D mybody;

    void Start()
    {
        mybody = this.GetComponent<Rigidbody2D>();

    }
    void FixedUpdate()
    {
        Vector2 myVel = mybody.velocity;
        myVel.y = speed;
        mybody.velocity = myVel;
    }
}


