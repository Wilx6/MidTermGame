using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{
    //  private Vector2 direction;

    private Rigidbody2D rb;
    public float jump;
    public float speed;
    private float Move;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    
    }

    // Update is called once per frame
    void Update()
    {

        Move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(Move * speed, rb.velocity.y);



        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
        }

       

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Death")
        {
            SceneManager.LoadScene(2);
        }
        else if (other.tag == "CaveEnter")
        {
            SceneManager.LoadScene(3);
        }
        else if (other.tag == "CaveExit")
        {
            SceneManager.LoadScene(4);
        }
        else if (other.tag == "Win")
        {
            SceneManager.LoadScene(5);
        }
    }


}
