using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 direction;
   

   


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>();

        if (Input.GetKeyDown(KeyCode.A))

        {
            direction = Vector2.left;
            transform.position = new Vector2(transform.position.x + direction.x, transform.position.y);
        }

        if (Input.GetKeyDown(KeyCode.D))

        {
            direction = Vector2.right;
            transform.position = new Vector2(transform.position.x + direction.x, transform.position.y);
        }

        if (Input.GetKeyDown(KeyCode.S))

        {
            direction = Vector2.down;
            transform.position = new Vector2(transform.position.x, transform.position.y + direction.y);
        }

        if (Input.GetKeyDown(KeyCode.W))

        {
            direction = Vector2.up;
            transform.position = new Vector2(transform.position.x, transform.position.y + direction.y);
        }
    }

}
