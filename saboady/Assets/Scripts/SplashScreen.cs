using System;
using UnityEngine;

public class SplashScreen : MonoBehaviour
{

    [SerializeField] private LoadingSystem.SCENE sceneToLoad;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonUp(0))
        {
            Debug.Log("Loading Scene: " + sceneToLoad);
            LoadScene();
        }
    }

    public void LoadScene()
    {
        LoadingSystem.Shared.LoadSceneAndThen(sceneToLoad, () => {
            // Do a camera fade or something if you want
            LoadingSystem.Shared.MakeCurrentSceneActive();
        });
    }
}
