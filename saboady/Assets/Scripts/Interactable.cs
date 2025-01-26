using UnityEngine;

public class Interactable : MonoBehaviour
{
    // Override this for each interactable in the game
    public (string, string) GetDialog(PlayerProgression progression) {
        return (ConstructorStrings.Shared.pond_midquest, 
            PlayerStrings.Shared.move_on);
    }
}
