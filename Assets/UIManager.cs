using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textDistContainer;
    [SerializeField] GameObject textPlace;

    public void ChangeBoxContents()
    {
        textPlace.SetActive(false);
        textDistContainer.text = "Item Collected!";
    }
}
