using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = 5f;
    private float movementHorizontal = 0f;
    private float movementVertical = 0f;
    private Rigidbody2D rigidBody;
    // Use this for initialization
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movementHorizontal = Input.GetAxis("Horizontal");
        if (movementHorizontal > 0f)
        {
            rigidBody.velocity = new Vector2(movementHorizontal * speed, rigidBody.velocity.y);
        }
        else if (movementHorizontal < 0f)
        {
            rigidBody.velocity = new Vector2(movementHorizontal * speed, rigidBody.velocity.y);
        }
        else
        {
            rigidBody.velocity = new Vector2(0, rigidBody.velocity.y);
        }
        movementVertical = Input.GetAxis("Vertical");
        if (movementVertical > 0f)
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, movementVertical * speed);
        }
        else if (movementVertical < 0f)
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, movementVertical * speed);
        }
        else
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, 0);
        }
    }

}
