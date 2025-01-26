using System;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    // Override this for each interactable in the game
    public virtual (string, string) GetDialog() {
        return ("", "");
    }

    public virtual void DismissAction() {
        
    }

    protected void Awake() {
        GetComponent<Collider>().isTrigger = true;
    }
}
