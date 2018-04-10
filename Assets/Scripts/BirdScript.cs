using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour {

    public float jumpForce = 200f;
    Rigidbody2D rb;
    public float forwardSpeed = 2f;
    public GameObject cam;
    public bool dead = false;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector2.up* jumpForce); //Vector2(0,1) == Vector.up
        }
        rb.transform.Translate(new Vector3(1, 0, 0) * forwardSpeed * Time.deltaTime);
        cam.transform.Translate(new Vector3(1, 0, 0) * forwardSpeed * Time.deltaTime);
        if (rb.transform.position.x> 18f)
        {
            dead = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        dead = true;
    }

}
