using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed = 0;
    private Vector2 movement;
    private bool checkForKeyPress = false;
    public TextMeshPro interactText;
    
    public void OnMove(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        interactText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
        if(checkForKeyPress)
        {
            checkKeyPress();
        }
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
        checkForKeyPress = true;
        interactText.gameObject.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Exited collision with " + other.name);
        // hide the message to the player
        checkForKeyPress = false;
        interactText.gameObject.SetActive(false);
    }

    void checkKeyPress()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Interaction pressed");
        }
    }
   

}

