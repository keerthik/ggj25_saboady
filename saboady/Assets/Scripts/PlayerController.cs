using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{

    public Animator animator;
    public float speed = 0;
    private Vector2 movement;
    private GameObject interactableObject;
    private bool isInteracting;
    public TextMeshPro interactText;
    
    private AudioManager audioManager;

    void Awake()
    {
        interactableObject = null;
        audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
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

    public float smooth = 3.0f;
    public void movePlayer()
    {
        Vector3 move = new Vector3(movement.x, 0, movement.y);

        if(move != Vector3.zero)
        {
            // Translate the player
            transform.Translate(move * speed * Time.deltaTime, Space.World);
            // Rotate the player
            //transform.LookAt(transform.position + new Vector3(movement.x, 0, movement.y));
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(move), Time.deltaTime * smooth);
     
            // Rotate the text to face the player
            interactText.transform.rotation = Quaternion.Slerp(interactText.transform.rotation, Quaternion.LookRotation(interactText.transform.position - Camera.main.transform.position), Time.deltaTime * smooth);

            // Play footstep sound
            audioManager.PlaySFX(AudioManager.SFX_TYPE.FOOTSTEP);
        }

        // Animation
        animator.SetFloat("Speed", movement.magnitude);
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
                (dialog, response) = idata.GetDialog();
                HudEntities.Shared.SetPortrait(idata.portrait);
                HudEntities.Shared.SetDialog(dialog, response);
                audioManager.PlaySFX(AudioManager.SFX_TYPE.DIALOGUE);
            } else {
                idata.DismissAction();
                HudEntities.Shared.DismissDialog();
                audioManager.PlaySFX(AudioManager.SFX_TYPE.DIALOGUE);
            }
        }
        if (Input.GetKeyUp(KeyCode.Space))
            GameDirector.Shared.good++;
        if (Input.GetKeyUp(KeyCode.Escape))
            GameDirector.Shared.good--;
    }
   

}

