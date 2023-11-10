using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DataHandler : MonoBehaviour
{
    public static DataHandler instance;
    public string userName;
    public TextMeshProUGUI userNameInput;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        } 
        else
        {
            Destroy(instance);
        }
    }

    public void SetName()
    {
        userName = userNameInput.text;
    }
}
