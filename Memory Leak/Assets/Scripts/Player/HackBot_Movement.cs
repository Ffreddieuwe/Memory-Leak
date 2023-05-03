using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HackBot_Movement : MonoBehaviour
{
    public float speed;

    private float horizontal;
    private float vertical;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(speed * horizontal, speed * vertical);
    }
}
