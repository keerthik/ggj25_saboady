using UnityEngine;

public class LevelStart : MonoBehaviour
{
    [SerializeField] private GameObject directorPrefab;
    [SerializeField] private GameObject playerControllerPrefab;
    [SerializeField] private GameObject stringsPrefab;
    [SerializeField] private GameObject hudPrefab;
    void Start()
    {
        if (GameDirector.Shared == null) {
            Instantiate(directorPrefab, Vector3.zero, Quaternion.identity);
        }
        Instantiate(playerControllerPrefab, transform.position, transform.rotation);
        Instantiate(stringsPrefab, Vector3.zero, Quaternion.identity);
        Instantiate(hudPrefab, Vector3.zero, Quaternion.identity);
    }

    void Update() {
        if (GameDirector.Shared.good > 7) {
            LoadingSystem.Shared.LoadSceneAndThen(LoadingSystem.SCENE.END_SCENE, () => {
                // Do a camera fade or something if you want
                LoadingSystem.Shared.MakeCurrentSceneActive();
        });

        }
    }
}
