using UnityEngine;

public class LevelStart : MonoBehaviour
{
    [SerializeField] private GameObject playerControllerPrefab;
    [SerializeField] private GameObject playerCameraPrefab;
    void Start()
    {
        Instantiate(playerControllerPrefab, transform.position, transform.rotation);
        // Instantiate(playerCameraPrefab, transform.position, transform.rotation); 
    }
}
