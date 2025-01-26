using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed = 0;
    private Vector2 movement;
    private GameObject interactableObject;
    private bool isInteracting;
    public TextMeshPro interactText;
    
    void Awake()
    {
        interactableObject = null;
    }
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
        if (!isInteracting)
        {
            movePlayer();
        }
        // interactableObject is not null if we're close to one
        if (interactableObject)
        {
            WaitForInteractPress();
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
        interactableObject = other.gameObject;
        interactText.gameObject.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Exited collision with " + other.name);
        // hide the message to the player
        interactableObject = null;
        interactText.gameObject.SetActive(false);
    }

    void WaitForInteractPress()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            isInteracting = !isInteracting;
            Interactable idata = interactableObject?.GetComponent<Interactable>();
            if (isInteracting) {
                string dialog, response;
                (dialog, response) = idata.GetDialog(GameDirector.Progress);
                HudEntities.Shared.SetDialog(dialog, response);
            } else {
                idata.DismissAction(GameDirector.Progress);
                HudEntities.Shared.DismissDialog();
            }
        }
    }
   

}

