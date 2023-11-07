using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using TMPro;
using UnityEngine;

public enum InputType
{
    Password,
    Email,
    Username,
}

public class SpecificInputField : MonoBehaviour
{

    [SerializeField] private InputType inputType;

    private void Awake()
    {
        if (inputType == InputType.Password)
        {
            TMP_InputField inputField = GetComponent<TMP_InputField>();
            inputField.contentType = TMP_InputField.ContentType.Password;
            inputField.characterLimit = 20;
            
        }

        if (inputType == InputType.Email)
        {
            TMP_InputField inputField = GetComponent<TMP_InputField>();
            inputField.contentType = TMP_InputField.ContentType.EmailAddress;
            inputField.characterLimit = 40;
        }
        
    }
}
