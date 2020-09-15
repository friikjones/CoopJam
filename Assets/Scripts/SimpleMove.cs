using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour {
    private Rigidbody rb;

    public float speed;

    public KeyCode up;
    public KeyCode down;
    public KeyCode right;
    public KeyCode left;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    void Update() {
        rb.velocity = Vector3.zero;
        if (Input.GetKey(up)) {
            rb.velocity += Vector3.forward * speed;
        }
        if (Input.GetKey(down)) {
            rb.velocity += Vector3.back * speed;
        }
        if (Input.GetKey(right)) {
            rb.velocity += Vector3.right * speed;
        }
        if (Input.GetKey(left)) {
            rb.velocity += Vector3.left * speed;
        }
    }
}
