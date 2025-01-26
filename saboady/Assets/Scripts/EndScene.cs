using TMPro;
using UnityEngine;

public class EndScene : MonoBehaviour
{

    public GameObject goodEndingText;
    public GameObject badEndingText;
    public GameObject goodEndingImage;
    public GameObject badEndingImage;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        goodEndingText.SetActive(false);
        badEndingText.SetActive(false);
        goodEndingImage.SetActive(false);
        badEndingImage.SetActive(false);

        if(GameDirector.Shared.niceEnding)
        {
            Debug.Log("You got the nice ending, Yay!");
            goodEndingText.gameObject.SetActive(true);
            goodEndingImage.gameObject.SetActive(true);
        }
        else
        {
            Debug.Log("You got the BAD ending!");
            badEndingText.gameObject.SetActive(true);
            badEndingImage.gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
