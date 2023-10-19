using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerMovement : MonoBehaviour
{

    
    
    private Rigidbody2D rb;
    public float jump;
    public float speed;
    private float Move;
   

    public static int playerCoin;
    public Text totalCoin;
    
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

      
            totalCoin.text = playerCoin.ToString();
          
    }

    

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Death")
        {
            SceneManager.LoadScene(2);
            playerCoin = 0;
        }
        else if (other.tag == "CaveEnter")
        {
            SceneManager.LoadScene(3);
            
        }
        else if (other.tag == "CaveExit")
        {
            SceneManager.LoadScene(4);
        }
        
        if (other.gameObject.CompareTag("CollectCoin"))
        {
            playerCoin = playerCoin + 1;
            Destroy(other.gameObject);
        }

        if(other.tag == "Finish" && playerCoin == 10)
        {
            SceneManager.LoadScene(5);
            playerCoin = 0;
        }
    }


}
