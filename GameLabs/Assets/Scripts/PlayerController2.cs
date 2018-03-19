using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour {
    private Rigidbody2D rBody;
    public float maxSpeed = 10;
    private float moveH;
    public GameObject leftEdge;
    public GameObject rightEdge;
    // Use this for initialization
    void Start () {
        rBody = GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void Update () {
        //if (!leftEdge || !rightEdge)
        //{
            moveH = Input.GetAxis("Horizontal");
            rBody.velocity = new Vector2(moveH * maxSpeed, rBody.velocity.y);
        //}
    }
}
