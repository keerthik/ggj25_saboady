using System;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    // Override this for each interactable in the game
    public virtual (string, string) GetDialog(PlayerProgression progress) {
        return (ConstructorStrings.Shared.pond_midquest, 
            PlayerStrings.Shared.move_on);
    }

    public virtual void DismissAction(PlayerProgression progress) {
        
    }
}
