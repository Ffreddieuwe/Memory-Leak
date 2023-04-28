using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private float Move;
    
    public float jump;
    public int totalJumps = 0;
    public bool isJumping;

    private Rigidbody2D rb;

    Vector2 originalPos;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("DemoLvl2"))
        {
            totalJumps = 1;
        }

        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(speed * Move, rb.velocity.y);

        

            if (Input.GetButtonDown("Jump") && (!isJumping || totalJumps == 1))
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
            if(totalJumps == 1)
            {
                totalJumps = 2;
                
            }
                
        }
        if(isJumping && totalJumps == 2)
        {
            totalJumps = 1;

        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
        
        
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            isJumping = true;
        }
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("PowerUp") && totalJumps == 0)
        {
            totalJumps = 1;
        }
        if(other.gameObject.CompareTag("DeathBarrier"))
        {
            transform.position = originalPos;
        }
    }

    
}



