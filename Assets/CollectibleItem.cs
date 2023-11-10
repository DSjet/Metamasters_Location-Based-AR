using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CollectibleItem : MonoBehaviour 
{
    [SerializeField] string collectibleName;
    [SerializeField] string collectibleDescription;
    [SerializeField] string collectibleType;

    private UIManager uiManager;

    private void Start()
    {
        if (GameObject.FindWithTag("UI Manager")  != null)
        {
            GameObject go = GameObject.FindWithTag("UI Manager");
            uiManager = go.GetComponent<UIManager>();
        }
        
    }


    private void Update()
    {
        GetTouch();
    }

    private void GetTouch()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Item Collected");
            uiManager.ChangeBoxContents();
            Destroy(gameObject);
        }

        if (Input.touchCount == 1)
        {
            Debug.Log("Item Collected");
            uiManager.ChangeBoxContents();
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        
    }
}
