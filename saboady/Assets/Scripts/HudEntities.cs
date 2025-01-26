using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class HudEntities : SingletonBehaviour<HudEntities>
{
    public GameObject lowerPanel;
    public List<GameObject> checkpoints_good;
    [SerializeField] GameObject dialogPanel;
    [SerializeField] Image dialogPortrait;
    [SerializeField] TMP_Text dialog;
    [SerializeField] TMP_Text response;

    protected override void Awake() {
        base.Awake();
        dialogPanel.SetActive(false);
        dialogPortrait.gameObject.SetActive(false);
    }

    public void SetPortrait(Texture2D portrait) {
        if (null == portrait) {
            dialogPortrait.gameObject.SetActive(false);
            return;
        }
        dialogPortrait.gameObject.SetActive(true);
        dialogPortrait.material.mainTexture = portrait;
    }

    public void SetDialog(string dialogStr, string responseKey) {
        dialogPanel.SetActive(true);
        dialog.text = dialogStr;
        response.text = $"{Basics.Shared.player[responseKey]} (E)";
    }

    public void DismissDialog() {
        dialogPanel.SetActive(false);
        dialogPortrait.gameObject.SetActive(false);
    }
}
