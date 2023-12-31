using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationPinInteractible : MonoBehaviour
{
    [SerializeField] private CollectibleItem collectibleItem;
    [SerializeField] float spawnForce;
    bool itemCollected = false;
    UIManager uiManager;

    public CollectibleItem CollectibleItem {  get { return collectibleItem; } set { collectibleItem = value; } }

    private void Start()
    {
        if (GameObject.FindWithTag("UI Manager") != null)
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
            Debug.Log("Touch detected");
            // Spawn object to the real world
            if(!itemCollected)
            {
                StartCoroutine(SpawnObject());
                itemCollected = true;
            }
            
        }

        if (Input.touchCount == 1)
        {
            Debug.Log("Touch detected");
            // Spawn object to the real world
            if (!itemCollected)
            {
                StartCoroutine(SpawnObject());
                itemCollected = true;
            }
        }
    }

    IEnumerator SpawnObject()
    {
        yield return new WaitForSeconds(0.5f);

        uiManager.IsArrived = true;

        Debug.Log("Item Spawned");

        Instantiate(collectibleItem, new Vector3(transform.position.x + 3, transform.position.y + 3, transform.position.z), Quaternion.identity);
    }
}
