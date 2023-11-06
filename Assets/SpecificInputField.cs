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
            GetComponent<TMP_InputField>().contentType = TMP_InputField.ContentType.Password;
        }

        if (inputType == InputType.Email)
        {
            GetComponent<TMP_InputField>().contentType = TMP_InputField.ContentType.EmailAddress;
        }
        
    }
}
