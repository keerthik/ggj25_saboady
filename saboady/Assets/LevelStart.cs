using UnityEngine;

public class LevelStart : MonoBehaviour
{
    [SerializeField] private GameObject playerControllerPrefab;
    void Start()
    {
        Instantiate(playerControllerPrefab, transform.position, transform.rotation);
    }
}
