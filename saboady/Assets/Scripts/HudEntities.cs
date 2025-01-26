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

    protected override void Awake() {
        base.Awake();
        dialogPanel.SetActive(false);
    }

    public void SetDialog(string dialogStr, string responseStr) {
        dialogPanel.SetActive(true);
        dialog.text = dialogStr;
        response.text = responseStr;
    }

    public void DismissDialog() {
        dialogPanel.SetActive(false);
    }

    void Start() {
    }
}
