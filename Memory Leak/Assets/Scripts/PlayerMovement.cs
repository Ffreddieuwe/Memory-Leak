using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private float Move;
    
    public float jump;
    public int doubleJump = 0;
    public bool isJumping;

    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("DemoLvl2"))
        {
            doubleJump = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(speed * Move, rb.velocity.y);

        

            if (Input.GetButtonDown("Jump") && (isJumping == false || doubleJump == 1))
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
            if(doubleJump == 1)
            {
                doubleJump = 2;
                
            }
                
        }
        if(isJumping == false && doubleJump == 2)
        {
            doubleJump = 1;

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
        if(other.gameObject.CompareTag("PowerUp"))
        {
            
            doubleJump = 1;
        }
    }

    
}



