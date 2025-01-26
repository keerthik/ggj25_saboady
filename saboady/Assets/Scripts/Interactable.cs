using System;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    // Override this for each interactable in the game
    public virtual (string, string) GetDialog(PlayerProgression progress) {
        return ("", "");
    }

    public virtual void DismissAction(PlayerProgression progress) {
        
    }
}
