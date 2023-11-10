using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangeName : MonoBehaviour
{
    DataHandler dataHandler;
    [SerializeField] TextMeshProUGUI userNameContainer;

    private void Awake()
    {
        dataHandler = DataHandler.instance;
        ChangeStringName();
    }

    private void ChangeStringName()
    {
        if (dataHandler.userName.Length > 8)
        {
            userNameContainer.text = "Hello," + dataHandler.userName.Substring(0, 5) + "...";
            return;
        }
        userNameContainer.text = "Hello," + dataHandler.userName;
    }
}
