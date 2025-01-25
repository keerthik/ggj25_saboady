using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 0;
    private Vector2 movement;

    public void OnMove(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
    }

    public void OnInteract(InputAction.CallbackContext context)
    {
        Debug.Log("Interacting...");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
    }

    public void movePlayer()
    {
        Vector3 move = new Vector3(movement.x, 0, movement.y);
        transform.Translate(move * speed * Time.deltaTime, Space.World);
    }


    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided with " + other.name);


        // show a message to the player

    }

    void OnTriggerStay(Collider other)
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E Pressed while interacting with: " + other.name);
        }
    }
}

