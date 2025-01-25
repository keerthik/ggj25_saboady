using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class HudEntities : SingletonBehaviour<HudEntities>
{
    public GameObject lowerPanel;
    public List<GameObject> checkpoints_good;
    [SerializeField] GameObject dialogPanel;
    [SerializeField] TMP_Text dialog;
    [SerializeField] TMP_Text response;

    public void SetDialog(string dialogStr, string responseStr) {
        dialog.text = dialogStr;
        response.text = responseStr;
    }

    void Start() {
        SetDialog(
            ConstructorStrings.Shared.park_welcome, 
            PlayerStrings.Shared.ok);
    }
}
